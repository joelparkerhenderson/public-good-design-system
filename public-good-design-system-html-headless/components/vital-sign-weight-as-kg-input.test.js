// vital-sign-weight-as-kg-input.test.js
// VitalSignWeightAsKgInput component test

const path = require('path');

describe('VitalSignWeightAsKgInput', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-weight-as-kg-input.html'));
  });

  it('should render the input element with correct class', async function() {
    const el = await $('input.vital-sign-weight-as-kg-input');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-weight-as-kg-input');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('input.vital-sign-weight-as-kg-input');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
