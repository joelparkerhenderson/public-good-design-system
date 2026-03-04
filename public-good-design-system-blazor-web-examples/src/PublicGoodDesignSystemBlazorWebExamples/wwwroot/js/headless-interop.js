// Roving tabindex keyboard navigation for TabBar, MenuBar, ToolBar
window.headlessInterop = {
    initRovingTabindex: function (containerEl) {
        if (!containerEl) return;
        const buttons = containerEl.querySelectorAll('[role="tab"], [role="menuitem"], button');
        if (buttons.length === 0) return;

        containerEl.addEventListener('keydown', function (e) {
            const items = Array.from(containerEl.querySelectorAll('[role="tab"], [role="menuitem"], button'));
            const current = items.indexOf(document.activeElement);
            if (current === -1) return;

            let next = -1;
            if (e.key === 'ArrowRight' || e.key === 'ArrowDown') {
                next = (current + 1) % items.length;
            } else if (e.key === 'ArrowLeft' || e.key === 'ArrowUp') {
                next = (current - 1 + items.length) % items.length;
            } else if (e.key === 'Home') {
                next = 0;
            } else if (e.key === 'End') {
                next = items.length - 1;
            }

            if (next !== -1) {
                e.preventDefault();
                items.forEach(item => item.setAttribute('tabindex', '-1'));
                items[next].setAttribute('tabindex', '0');
                items[next].focus();
            }
        });
    }
};
