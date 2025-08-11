// vital-sign-body-fat-as-percentage-input.test.js
// VitalSignBodyFatAsPercentageInput component test

const path = require('path');

describe('VitalSignBodyFatAsPercentageInput', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-body-fat-as-percentage-input.html'));
  });

  it('should render the input element with correct class', async function() {
    const el = await $('input.vital-sign-body-fat-as-percentage-input');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-body-fat-as-percentage-input');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('input.vital-sign-body-fat-as-percentage-input');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
