// gantt-table-data.test.js
// GanttTableData component test

const path = require('path');

describe('GanttTableData', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'gantt-table-data.html'));
  });

  it('should render the td element with correct class', async function() {
    const el = await $('td.gantt-table-data');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('gantt-table-data');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('td.gantt-table-data');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
