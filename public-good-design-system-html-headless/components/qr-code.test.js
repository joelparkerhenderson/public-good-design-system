// qr-code.test.js
// QrCode component test

const path = require('path');

describe('QrCode', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'qr-code.html'));
  });

  it('should render the div element with correct class', async function() {
    const el = await $('div.qr-code');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('qr-code');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('div.qr-code');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
