// vital-sign-blood-pressure-systolic-as-mmhg-view.test.js
// VitalSignBloodPressureSystolicAsMmhgView component test

const path = require('path');

describe('VitalSignBloodPressureSystolicAsMmhgView', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-blood-pressure-systolic-as-mmhg-view.html'));
  });

  it('should render the span element with correct class', async function() {
    const el = await $('span.vital-sign-blood-pressure-systolic-as-mmhg-view');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-blood-pressure-systolic-as-mmhg-view');
  });

  it('should have the correct ARIA role', async function() {
    const el = await $('span.vital-sign-blood-pressure-systolic-as-mmhg-view');
    const roleAttr = await el.getAttribute('role');
    expect(roleAttr).toBe('img');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('span.vital-sign-blood-pressure-systolic-as-mmhg-view');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
