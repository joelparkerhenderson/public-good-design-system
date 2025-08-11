// vital-sign-height-as-cm-input.test.js
// VitalSignHeightAsCmInput component test

const path = require('path');

describe('VitalSignHeightAsCmInput', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-height-as-cm-input.html'));
  });

  it('should render the input element with correct class', async function() {
    const el = await $('input.vital-sign-height-as-cm-input');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-height-as-cm-input');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('input.vital-sign-height-as-cm-input');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
