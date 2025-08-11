// review-date.test.js
// ReviewDate component test

const path = require('path');

describe('ReviewDate', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'review-date.html'));
  });

  it('should render the span element with correct class', async function() {
    const el = await $('span.review-date');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('review-date');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('span.review-date');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
