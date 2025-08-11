// vital-sign-heart-rate-variability-input.test.js
// VitalSignHeartRateVariabilityInput component test

const path = require('path');

describe('VitalSignHeartRateVariabilityInput', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-heart-rate-variability-input.html'));
  });

  it('should render the input element with correct class', async function() {
    const el = await $('input.vital-sign-heart-rate-variability-input');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-heart-rate-variability-input');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('input.vital-sign-heart-rate-variability-input');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
