// date-range.test.js
// DateRange component test

const path = require('path');

describe('DateRange', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'date-range.html'));
  });

  it('should render the span element with correct class', async function() {
    const el = await $('span.date-range');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('date-range');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('span.date-range');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
