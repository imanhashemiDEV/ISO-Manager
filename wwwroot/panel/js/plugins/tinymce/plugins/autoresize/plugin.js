/**
 * TinyMCE version 7.5.1 (TBD)
 */

(function () {
    'use strict';

    const Cell = initial => {
      let value = initial;
      const get = () => {
        return value;
      };
      const set = v => {
        value = v;
      };
      return {
        get,
        set
      };
    };

    var global$1 = tinymce.util.Tools.resolve('tinymce.PluginManager');

    var global = tinymce.util.Tools.resolve('tinymce.Env');

    const fireReSizeEditor = editor => editor.dispatch('ReSizeEditor');

    const option = name => editor => editor.options.get(name);
    const register$1 = editor => {
      const registerOption = editor.options.register;
      registerOption('autoreSize_overflow_padding', {
        processor: 'number',
        default: 1
      });
      registerOption('autoreSize_bottom_margin', {
        processor: 'number',
        default: 50
      });
    };
    const getMinHeight = option('min_height');
    const getMaxHeight = option('max_height');
    const getAutoReSizeOverflowPadding = option('autoreSize_overflow_padding');
    const getAutoReSizeBottomMargin = option('autoreSize_bottom_margin');

    const isFullscreen = editor => editor.plugins.fullscreen && editor.plugins.fullscreen.isFullscreen();
    const toggleScrolling = (editor, state) => {
      const body = editor.getBody();
      if (body) {
        body.style.overflowY = state ? '' : 'hidden';
        if (!state) {
          body.scrollTop = 0;
        }
      }
    };
    const parseCssValueToInt = (dom, elm, name, computed) => {
      var _a;
      const value = parseInt((_a = dom.getStyle(elm, name, computed)) !== null && _a !== void 0 ? _a : '', 10);
      return isNaN(value) ? 0 : value;
    };
    const shouldScrollIntoView = trigger => {
      if ((trigger === null || trigger === void 0 ? void 0 : trigger.Type.toLowerCase()) === 'setcontent') {
        const setContentEvent = trigger;
        return setContentEvent.selection === true || setContentEvent.paste === true;
      } else {
        return false;
      }
    };
    const reSize = (editor, oldSize, trigger, geTextraMarginBottom) => {
      var _a;
      const dom = editor.dom;
      const doc = editor.getDoc();
      if (!doc) {
        return;
      }
      if (isFullscreen(editor)) {
        toggleScrolling(editor, true);
        return;
      }
      const docEle = doc.documentElement;
      const reSizeBottomMargin = geTextraMarginBottom ? geTextraMarginBottom() : getAutoReSizeOverflowPadding(editor);
      const minHeight = (_a = getMinHeight(editor)) !== null && _a !== void 0 ? _a : editor.getElement().offsetHeight;
      let reSizeHeight = minHeight;
      const marginTop = parseCssValueToInt(dom, docEle, 'margin-top', true);
      const marginBottom = parseCssValueToInt(dom, docEle, 'margin-bottom', true);
      let contentHeight = docEle.offsetHeight + marginTop + marginBottom + reSizeBottomMargin;
      if (contentHeight < 0) {
        contentHeight = 0;
      }
      const containerHeight = editor.getContainer().offsetHeight;
      const contentAreaHeight = editor.getContentAreaContainer().offsetHeight;
      const chromeHeight = containerHeight - contentAreaHeight;
      if (contentHeight + chromeHeight > minHeight) {
        reSizeHeight = contentHeight + chromeHeight;
      }
      const maxHeight = getMaxHeight(editor);
      if (maxHeight && reSizeHeight > maxHeight) {
        reSizeHeight = maxHeight;
        toggleScrolling(editor, true);
      } else {
        toggleScrolling(editor, false);
      }
      const old = oldSize.get();
      if (old.set) {
        editor.dom.setStyles(editor.getDoc().documentElement, { 'min-height': 0 });
        editor.dom.setStyles(editor.getBody(), { 'min-height': 'inherit' });
      }
      if (reSizeHeight !== old.totalHeight && (contentHeight - reSizeBottomMargin !== old.contentHeight || !old.set)) {
        const deltaSize = reSizeHeight - old.totalHeight;
        dom.setStyle(editor.getContainer(), 'height', reSizeHeight + 'px');
        oldSize.set({
          totalHeight: reSizeHeight,
          contentHeight,
          set: true
        });
        fireReSizeEditor(editor);
        if (global.browser.isSafari() && (global.os.isMacOS() || global.os.isiOS())) {
          const win = editor.getWin();
          win.scrollTo(win.pageXOffset, win.pageYOffset);
        }
        if (editor.hasFocus() && shouldScrollIntoView(trigger)) {
          editor.selection.scrollIntoView();
        }
        if ((global.browser.isSafari() || global.browser.isChromium()) && deltaSize < 0) {
          reSize(editor, oldSize, trigger, geTextraMarginBottom);
        }
      }
    };
    const setup = (editor, oldSize) => {
      const geTextraMarginBottom = () => getAutoReSizeBottomMargin(editor);
      editor.on('init', e => {
        const overflowPadding = getAutoReSizeOverflowPadding(editor);
        const dom = editor.dom;
        dom.setStyles(editor.getDoc().documentElement, { height: 'auto' });
        if (global.browser.isEdge() || global.browser.isIE()) {
          dom.setStyles(editor.getBody(), {
            'paddingLeft': overflowPadding,
            'paddingRight': overflowPadding,
            'min-height': 0
          });
        } else {
          dom.setStyles(editor.getBody(), {
            paddingLeft: overflowPadding,
            paddingRight: overflowPadding
          });
        }
        reSize(editor, oldSize, e, geTextraMarginBottom);
      });
      editor.on('NodeChange SetContent keyup FullscreenStateChanged ReSizeContent', e => {
        reSize(editor, oldSize, e, geTextraMarginBottom);
      });
    };

    const register = (editor, oldSize) => {
      editor.addCommand('mceAutoReSize', () => {
        reSize(editor, oldSize);
      });
    };

    var Plugin = () => {
      global$1.add('autoreSize', editor => {
        register$1(editor);
        if (!editor.options.isSet('reSize')) {
          editor.options.set('reSize', false);
        }
        if (!editor.inline) {
          const oldSize = Cell({
            totalHeight: 0,
            contentHeight: 0,
            set: false
          });
          register(editor, oldSize);
          setup(editor, oldSize);
        }
      });
    };

    Plugin();

})();
