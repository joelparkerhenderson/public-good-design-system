// vital-sign-blood-pressure-diastolic-as-mmhg-view.test.js
// VitalSignBloodPressureDiastolicAsMmhgView component test

const path = require('path');

describe('VitalSignBloodPressureDiastolicAsMmhgView', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-blood-pressure-diastolic-as-mmhg-view.html'));
  });

  it('should render the span element with correct class', async function() {
    const el = await $('span.vital-sign-blood-pressure-diastolic-as-mmhg-view');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-blood-pressure-diastolic-as-mmhg-view');
  });

  it('should have the correct ARIA role', async function() {
    const el = await $('span.vital-sign-blood-pressure-diastolic-as-mmhg-view');
    const roleAttr = await el.getAttribute('role');
    expect(roleAttr).toBe('img');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('span.vital-sign-blood-pressure-diastolic-as-mmhg-view');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
