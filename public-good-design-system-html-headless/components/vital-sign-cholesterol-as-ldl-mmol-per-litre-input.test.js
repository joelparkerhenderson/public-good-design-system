// vital-sign-cholesterol-as-ldl-mmol-per-litre-input.test.js
// VitalSignCholesterolAsLdlMmolPerLitreInput component test

const path = require('path');

describe('VitalSignCholesterolAsLdlMmolPerLitreInput', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-cholesterol-as-ldl-mmol-per-litre-input.html'));
  });

  it('should render the input element with correct class', async function() {
    const el = await $('input.vital-sign-cholesterol-as-ldl-mmol-per-litre-input');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-cholesterol-as-ldl-mmol-per-litre-input');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('input.vital-sign-cholesterol-as-ldl-mmol-per-litre-input');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
