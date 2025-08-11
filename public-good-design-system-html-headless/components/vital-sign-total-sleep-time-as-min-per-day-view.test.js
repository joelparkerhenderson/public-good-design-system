// vital-sign-total-sleep-time-as-min-per-day-view.test.js
// VitalSignTotalSleepTimeAsMinPerDayView component test

const path = require('path');

describe('VitalSignTotalSleepTimeAsMinPerDayView', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-total-sleep-time-as-min-per-day-view.html'));
  });

  it('should render the span element with correct class', async function() {
    const el = await $('span.vital-sign-total-sleep-time-as-min-per-day-view');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-total-sleep-time-as-min-per-day-view');
  });

  it('should have the correct ARIA role', async function() {
    const el = await $('span.vital-sign-total-sleep-time-as-min-per-day-view');
    const roleAttr = await el.getAttribute('role');
    expect(roleAttr).toBe('img');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('span.vital-sign-total-sleep-time-as-min-per-day-view');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
