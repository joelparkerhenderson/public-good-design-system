// vital-sign-respiratory-rate-as-breaths-per-minute-input.test.js
// VitalSignRespiratoryRateAsBreathsPerMinuteInput component test

const path = require('path');

describe('VitalSignRespiratoryRateAsBreathsPerMinuteInput', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-respiratory-rate-as-breaths-per-minute-input.html'));
  });

  it('should render the input element with correct class', async function() {
    const el = await $('input.vital-sign-respiratory-rate-as-breaths-per-minute-input');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-respiratory-rate-as-breaths-per-minute-input');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('input.vital-sign-respiratory-rate-as-breaths-per-minute-input');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
