// accordion-nav-list.test.js
// AccordionNavList component test

const path = require('path');

describe('AccordionNavList', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'accordion-nav-list.html'));
  });

  it('should render the ol element with correct class', async function() {
    const el = await $('ol.accordion-nav-list');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('accordion-nav-list');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('ol.accordion-nav-list');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
