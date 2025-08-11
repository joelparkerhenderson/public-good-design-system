// gantt-table-col.test.js
// GanttTableCol component test

const path = require('path');

describe('GanttTableCol', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'gantt-table-col.html'));
  });

  it('should render the th element with correct class', async function() {
    const el = await $('th.gantt-table-col');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('gantt-table-col');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('th.gantt-table-col');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
