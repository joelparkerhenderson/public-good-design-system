// tag.test.js
// Tag component test

const path = require('path');

describe('Tag', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'tag.html'));
  });

  it('should render the span element with correct class', async function() {
    const el = await $('span.tag');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('tag');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('span.tag');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
