// vital-sign-height-as-cm-view.test.js
// VitalSignHeightAsCmView component test

const path = require('path');

describe('VitalSignHeightAsCmView', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'vital-sign-height-as-cm-view.html'));
  });

  it('should render the span element with correct class', async function() {
    const el = await $('span.vital-sign-height-as-cm-view');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('vital-sign-height-as-cm-view');
  });

  it('should have the correct ARIA role', async function() {
    const el = await $('span.vital-sign-height-as-cm-view');
    const roleAttr = await el.getAttribute('role');
    expect(roleAttr).toBe('img');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('span.vital-sign-height-as-cm-view');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
