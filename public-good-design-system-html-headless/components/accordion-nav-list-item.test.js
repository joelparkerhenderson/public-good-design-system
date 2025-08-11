// accordion-nav-list-item.test.js
// AccordionNavListItem component test

const path = require('path');

describe('AccordionNavListItem', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'accordion-nav-list-item.html'));
  });

  it('should render the li element with correct class', async function() {
    const el = await $('li.accordion-nav-list-item');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('accordion-nav-list-item');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('li.accordion-nav-list-item');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
