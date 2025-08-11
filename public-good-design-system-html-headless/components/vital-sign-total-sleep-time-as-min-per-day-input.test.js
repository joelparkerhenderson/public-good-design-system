// vital-sign-total-sleep-time-as-min-per-day-input.test.js
// VitalSignTotalSleepTimeAsMinPerDayInput component test

const path = require('path');

describe('VitalSignTotalSleepTimeAsMinPerDayInput', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-total-sleep-time-as-min-per-day-input.html'));
  });

  it('should render the input element with correct class', async function() {
    const el = await $('input.vital-sign-total-sleep-time-as-min-per-day-input');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-total-sleep-time-as-min-per-day-input');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('input.vital-sign-total-sleep-time-as-min-per-day-input');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
