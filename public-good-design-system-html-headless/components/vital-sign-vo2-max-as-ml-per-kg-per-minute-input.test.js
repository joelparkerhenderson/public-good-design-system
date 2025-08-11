// vital-sign-vo2-max-as-ml-per-kg-per-minute-input.test.js
// VitalSignVo2MaxAsMlPerKgPerMinuteInput component test

const path = require('path');

describe('VitalSignVo2MaxAsMlPerKgPerMinuteInput', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-vo2-max-as-ml-per-kg-per-minute-input.html'));
  });

  it('should render the input element with correct class', async function() {
    const el = await $('input.vital-sign-vo2-max-as-ml-per-kg-per-minute-input');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-vo2-max-as-ml-per-kg-per-minute-input');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('input.vital-sign-vo2-max-as-ml-per-kg-per-minute-input');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
