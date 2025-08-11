// vital-sign-sleep-score-as-0-to-100-input.test.js
// VitalSignSleepScoreAs0To100Input component test

const path = require('path');

describe('VitalSignSleepScoreAs0To100Input', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-sleep-score-as-0-to-100-input.html'));
  });

  it('should render the input element with correct class', async function() {
    const el = await $('input.vital-sign-sleep-score-as-0-to-100-input');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-sleep-score-as-0-to-100-input');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('input.vital-sign-sleep-score-as-0-to-100-input');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
