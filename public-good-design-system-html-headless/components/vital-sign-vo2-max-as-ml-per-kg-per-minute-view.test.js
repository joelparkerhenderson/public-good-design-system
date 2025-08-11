// vital-sign-vo2-max-as-ml-per-kg-per-minute-view.test.js
// VitalSignVo2MaxAsMlPerKgPerMinuteView component test

const path = require('path');

describe('VitalSignVo2MaxAsMlPerKgPerMinuteView', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-vo2-max-as-ml-per-kg-per-minute-view.html'));
  });

  it('should render the span element with correct class', async function() {
    const el = await $('span.vital-sign-vo2-max-as-ml-per-kg-per-minute-view');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-vo2-max-as-ml-per-kg-per-minute-view');
  });

  it('should have the correct ARIA role', async function() {
    const el = await $('span.vital-sign-vo2-max-as-ml-per-kg-per-minute-view');
    const roleAttr = await el.getAttribute('role');
    expect(roleAttr).toBe('img');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('span.vital-sign-vo2-max-as-ml-per-kg-per-minute-view');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
