// vital-sign-blood-pressure-diastolic-as-mmhg-input.test.js
// VitalSignBloodPressureDiastolicAsMmhgInput component test

const path = require('path');

describe('VitalSignBloodPressureDiastolicAsMmhgInput', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-blood-pressure-diastolic-as-mmhg-input.html'));
  });

  it('should render the input element with correct class', async function() {
    const el = await $('input.vital-sign-blood-pressure-diastolic-as-mmhg-input');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-blood-pressure-diastolic-as-mmhg-input');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('input.vital-sign-blood-pressure-diastolic-as-mmhg-input');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
