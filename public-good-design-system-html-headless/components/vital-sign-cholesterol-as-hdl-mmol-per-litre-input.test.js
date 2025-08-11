// vital-sign-cholesterol-as-hdl-mmol-per-litre-input.test.js
// VitalSignCholesterolAsHdlMmolPerLitreInput component test

const path = require('path');

describe('VitalSignCholesterolAsHdlMmolPerLitreInput', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-cholesterol-as-hdl-mmol-per-litre-input.html'));
  });

  it('should render the input element with correct class', async function() {
    const el = await $('input.vital-sign-cholesterol-as-hdl-mmol-per-litre-input');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-cholesterol-as-hdl-mmol-per-litre-input');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('input.vital-sign-cholesterol-as-hdl-mmol-per-litre-input');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
