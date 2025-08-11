// breadcrumb-nav-list.test.js
// BreadcrumbNavList component test

const path = require('path');

describe('BreadcrumbNavList', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'breadcrumb-nav-list.html'));
  });

  it('should render the ol element with correct class', async function() {
    const el = await $('ol.breadcrumb-nav-list');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('breadcrumb-nav-list');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('ol.breadcrumb-nav-list');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
