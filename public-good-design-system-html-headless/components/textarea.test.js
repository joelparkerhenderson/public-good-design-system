// textarea.test.js
// Textarea component test

const path = require('path');

describe('Textarea', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'textarea.html'));
  });

  it('should render the textarea element with correct class', async function() {
    const el = await $('textarea.textarea');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('textarea');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('textarea.textarea');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
