// breadcrumb-nav-list-item.test.js
// BreadcrumbNavListItem component test

const path = require('path');

describe('BreadcrumbNavListItem', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'breadcrumb-nav-list-item.html'));
  });

  it('should render the li element with correct class', async function() {
    const el = await $('li.breadcrumb-nav-list-item');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('breadcrumb-nav-list-item');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('li.breadcrumb-nav-list-item');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
