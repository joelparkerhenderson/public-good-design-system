// vital-sign-body-fat-as-percentage-view.test.js
// VitalSignBodyFatAsPercentageView component test

const path = require('path');

describe('VitalSignBodyFatAsPercentageView', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-body-fat-as-percentage-view.html'));
  });

  it('should render the span element with correct class', async function() {
    const el = await $('span.vital-sign-body-fat-as-percentage-view');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-body-fat-as-percentage-view');
  });

  it('should have the correct ARIA role', async function() {
    const el = await $('span.vital-sign-body-fat-as-percentage-view');
    const roleAttr = await el.getAttribute('role');
    expect(roleAttr).toBe('img');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('span.vital-sign-body-fat-as-percentage-view');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
