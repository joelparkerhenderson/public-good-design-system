// vital-sign-sleep-score-as-0-to-100-view.test.js
// VitalSignSleepScoreAs0To100View component test

const path = require('path');

describe('VitalSignSleepScoreAs0To100View', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-sleep-score-as-0-to-100-view.html'));
  });

  it('should render the span element with correct class', async function() {
    const el = await $('span.vital-sign-sleep-score-as-0-to-100-view');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-sleep-score-as-0-to-100-view');
  });

  it('should have the correct ARIA role', async function() {
    const el = await $('span.vital-sign-sleep-score-as-0-to-100-view');
    const roleAttr = await el.getAttribute('role');
    expect(roleAttr).toBe('img');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('span.vital-sign-sleep-score-as-0-to-100-view');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
