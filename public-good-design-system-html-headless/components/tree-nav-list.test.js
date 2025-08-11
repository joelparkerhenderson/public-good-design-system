// tree-nav-list.test.js
// TreeNavList component test

const path = require('path');

describe('TreeNavList', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'tree-nav-list.html'));
  });

  it('should render the ol element with correct class', async function() {
    const el = await $('ol.tree-nav-list');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('tree-nav-list');
  });

  it('should have the correct ARIA role', async function() {
    const el = await $('ol.tree-nav-list');
    const roleAttr = await el.getAttribute('role');
    expect(roleAttr).toBe('tree');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('ol.tree-nav-list');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
