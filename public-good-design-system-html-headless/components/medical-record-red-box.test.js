// medical-record-red-box.test.js
// MedicalRecordRedBox component test

const path = require('path');

describe('MedicalRecordRedBox', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'medical-record-red-box.html'));
  });

  it('should render the div element with correct class', async function() {
    const el = await $('div.medical-record-red-box');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('medical-record-red-box');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('div.medical-record-red-box');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
