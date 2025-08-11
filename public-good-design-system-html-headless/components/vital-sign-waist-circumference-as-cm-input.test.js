// vital-sign-waist-circumference-as-cm-input.test.js
// VitalSignWaistCircumferenceAsCmInput component test

const path = require('path');

describe('VitalSignWaistCircumferenceAsCmInput', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-waist-circumference-as-cm-input.html'));
  });

  it('should render the input element with correct class', async function() {
    const el = await $('input.vital-sign-waist-circumference-as-cm-input');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-waist-circumference-as-cm-input');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('input.vital-sign-waist-circumference-as-cm-input');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
