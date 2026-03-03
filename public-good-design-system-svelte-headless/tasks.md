# Tasks: Public Good Design System Plus Svelte

Reference: [plan.md](plan.md)

## Legend

- [ ] Not started
- [~] In progress
- [x] Completed

---

## Infrastructure Tasks

- [ ] **INFRA-01**: Add `svelte` to devDependencies in package.json — See [plan.md § 2a](plan.md#2a-add-missing-dependencies)
- [ ] **INFRA-02**: Create `vitest-setup.js` — See [plan.md § 2b](plan.md#2b-create-vitest-setupjs)
- [ ] **INFRA-03**: Verify test pipeline runs end-to-end — See [plan.md § 2c](plan.md#2c-verify-test-pipeline)
- [ ] **INFRA-04**: Fix CLAUDE.md typo "Typscript" → "TypeScript" — See [plan.md § 3c](plan.md#3c-typescript-conventions)

---

## Component Tasks

Each component task produces 4 files per [plan.md § 4](plan.md#4-component-implementation-template):

1. CLAUDE.md (updated with implementation notes)
2. index.md (created if missing, kept if exists)
3. {ComponentName}.svelte (headless component)
4. {ComponentName}.svelte.test.ts (testing-library tests)

| #   | Task ID  | Component                                     | Directory                                                      | Has index.md | Status |
| --- | -------- | --------------------------------------------- | -------------------------------------------------------------- | :----------: | :----: |
| 1   | COMP-001 | Accordion                                     | components/accordion                                           |     Yes      |  [ ]   |
| 2   | COMP-002 | ActionLink                                    | components/action-link                                         |     Yes      |  [ ]   |
| 3   | COMP-003 | Alert                                         | components/alert                                               |     Yes      |  [ ]   |
| 4   | COMP-004 | AlertDialog                                   | components/alert-dialog                                        |      No      |  [ ]   |
| 5   | COMP-005 | AngleSlider                                   | components/angle-slider                                        |      No      |  [ ]   |
| 6   | COMP-006 | AspectRatioContainer                          | components/aspect-ratio-container                              |      No      |  [ ]   |
| 7   | COMP-007 | Avatar                                        | components/avatar-circle                                       |     Yes      |  [ ]   |
| 8   | COMP-008 | BackLink                                      | components/back-link                                           |     Yes      |  [ ]   |
| 9   | COMP-009 | Badge                                         | components/badge                                               |     Yes      |  [ ]   |
| 10  | COMP-010 | Banner                                        | components/banner                                              |     Yes      |  [ ]   |
| 11  | COMP-011 | BeachBall                                     | components/beach-ball                                          |     Yes      |  [ ]   |
| 12  | COMP-012 | Breadcrumb                                    | components/breadcrumb                                          |      No      |  [ ]   |
| 13  | COMP-013 | Breadcrumbs                                   | components/breadcrumbs                                         |     Yes      |  [ ]   |
| 14  | COMP-014 | Button                                        | components/button                                              |     Yes      |  [ ]   |
| 15  | COMP-015 | ButtonInput                                   | components/button-input                                        |      No      |  [ ]   |
| 16  | COMP-016 | ButtonTogglePressablePressed                  | components/button-with-pressable-or-pressed                    |      No      |  [ ]   |
| 17  | COMP-017 | CalendarTable                                 | components/calendar-board                                      |      No      |  [ ]   |
| 18  | COMP-018 | CalendarInput                                 | components/calendar-input                                      |     Yes      |  [ ]   |
| 19  | COMP-019 | CalendarRangePicker                           | components/calendar-range-picker                               |      No      |  [ ]   |
| 20  | COMP-020 | CallToAction                                  | components/call-to-action                                      |     Yes      |  [ ]   |
| 21  | COMP-021 | Caption                                       | components/caption                                             |     Yes      |  [ ]   |
| 22  | COMP-022 | Card                                          | components/card                                                |     Yes      |  [ ]   |
| 23  | COMP-023 | CareCard                                      | components/care-card                                           |      No      |  [ ]   |
| 24  | COMP-024 | Carousel                                      | components/carousel                                            |      No      |  [ ]   |
| 25  | COMP-025 | Character                                     | components/character                                           |      No      |  [ ]   |
| 26  | COMP-026 | CharacterCounter                              | components/character-counter                                   |     Yes      |  [ ]   |
| 27  | COMP-027 | Chart                                         | components/chart                                               |      No      |  [ ]   |
| 28  | COMP-028 | Checkbox                                      | components/checkbox                                            |     Yes      |  [ ]   |
| 29  | COMP-029 | CheckboxInput                                 | components/checkbox-input                                      |      No      |  [ ]   |
| 30  | COMP-030 | CheckList                                     | components/CheckList                                           |     Yes      |  [ ]   |
| 31  | COMP-031 | Clipboard                                     | components/clipboard-copy-button                               |      No      |  [ ]   |
| 32  | COMP-032 | Collapsible                                   | components/collapsible                                         |      No      |  [ ]   |
| 33  | COMP-033 | ColorInput                                    | components/color-input                                         |      No      |  [ ]   |
| 34  | COMP-034 | ColorPicker                                   | components/color-picker                                        |      No      |  [ ]   |
| 35  | COMP-035 | ColorPicker                                   | components/color-picker                                        |      No      |  [ ]   |
| 36  | COMP-036 | ColorPickerSwatch                             | components/color-picker-swatch-button                          |      No      |  [ ]   |
| 37  | COMP-037 | Combobox                                      | components/combobox                                            |      No      |  [ ]   |
| 38  | COMP-038 | Command                                       | components/command                                             |      No      |  [ ]   |
| 39  | COMP-039 | ContentsList                                  | components/contents-list                                       |      No      |  [ ]   |
| 40  | COMP-040 | ContextMenu                                   | components/context-menu                                        |      No      |  [ ]   |
| 41  | COMP-041 | DataFilterForm                                | components/data-filter-form                                    |      No      |  [ ]   |
| 42  | COMP-042 | DataTable                                     | components/data-table                                          |      No      |  [ ]   |
| 43  | COMP-043 | DateField                                     | components/date-field                                          |      No      |  [ ]   |
| 44  | COMP-044 | DateInput                                     | components/date-input                                          |      No      |  [ ]   |
| 45  | COMP-045 | DatePicker                                    | components/date-picker                                         |     Yes      |  [ ]   |
| 46  | COMP-046 | DateRange                                     | components/date-range                                          |      No      |  [ ]   |
| 47  | COMP-047 | DateRangePicker                               | components/date-range-picker                                   |      No      |  [ ]   |
| 48  | COMP-048 | DatetimeLocalInput                            | components/datetime-local-input                                |      No      |  [ ]   |
| 49  | COMP-049 | Details                                       | components/details                                             |     Yes      |  [ ]   |
| 50  | COMP-050 | Dial                                          | components/dial                                                |     Yes      |  [ ]   |
| 51  | COMP-051 | Dialog                                        | components/dialog                                              |     Yes      |  [ ]   |
| 52  | COMP-052 | DoDontList                                    | components/do-dont-list                                        |     Yes      |  [ ]   |
| 53  | COMP-053 | DoList                                        | components/do-list                                             |      No      |  [ ]   |
| 54  | COMP-054 | DontList                                      | components/dont-list                                           |      No      |  [ ]   |
| 55  | COMP-055 | Drawer                                        | components/drawer                                              |      No      |  [ ]   |
| 56  | COMP-056 | DropdownMenu                                  | components/dropdown-menu                                       |     Yes      |  [ ]   |
| 57  | COMP-057 | Editable                                      | components/editable                                            |      No      |  [ ]   |
| 58  | COMP-058 | EditableForm                                  | components/editable-form                                       |      No      |  [ ]   |
| 59  | COMP-059 | EmailAddressInput                             | components/email-address-input                                 |      No      |  [ ]   |
| 60  | COMP-060 | EmailAddressView                              | components/email-link                                          |      No      |  [ ]   |
| 61  | COMP-061 | EmailInput                                    | components/email-input                                         |      No      |  [ ]   |
| 62  | COMP-062 | Emoji                                         | components/emoji                                               |      No      |  [ ]   |
| 63  | COMP-063 | EmojiCharacterPicker                          | components/emoji-character-picker                              |      No      |  [ ]   |
| 64  | COMP-064 | ErrorMessage                                  | components/error-message                                       |     Yes      |  [ ]   |
| 65  | COMP-065 | ErrorSummary                                  | components/error-summary                                       |     Yes      |  [ ]   |
| 66  | COMP-066 | Expander                                      | components/expander                                            |      No      |  [ ]   |
| 67  | COMP-067 | Field                                         | components/field                                               |      No      |  [ ]   |
| 68  | COMP-068 | Fieldset                                      | components/fieldset                                            |     Yes      |  [ ]   |
| 69  | COMP-069 | FileDialog                                    | components/file-dialog                                         |     Yes      |  [ ]   |
| 70  | COMP-070 | FileInput                                     | components/file-input                                          |      No      |  [ ]   |
| 71  | COMP-071 | FileManager                                   | components/file-manager                                        |      No      |  [ ]   |
| 72  | COMP-072 | FileUpload                                    | components/file-upload                                         |      No      |  [ ]   |
| 73  | COMP-073 | FiveFaceRatingPicker                          | components/five-face-rating-picker                             |      No      |  [ ]   |
| 74  | COMP-074 | FiveFaceRatingView                            | components/five-face-rating-view                               |      No      |  [ ]   |
| 75  | COMP-075 | FiveStarRatingPicker                          | components/five-star-rating-picker                             |      No      |  [ ]   |
| 76  | COMP-076 | FiveStarRatingView                            | components/five-star-rating-view                               |      No      |  [ ]   |
| 77  | COMP-077 | Flair                                         | components/flair                                               |     Yes      |  [ ]   |
| 78  | COMP-078 | FloatingPanel                                 | components/floating-panel                                      |      No      |  [ ]   |
| 79  | COMP-079 | Footer                                        | components/footer                                              |     Yes      |  [ ]   |
| 80  | COMP-080 | Footnote                                      | components/footnote                                            |      No      |  [ ]   |
| 81  | COMP-081 | Form                                          | components/form                                                |      No      |  [ ]   |
| 82  | COMP-082 | GanntChart                                    | components/gannt-chart                                         |      No      |  [ ]   |
| 83  | COMP-083 | Gauge                                         | components/gauge                                               |     Yes      |  [ ]   |
| 84  | COMP-084 | HamburgerMenu                                 | components/hamburger-menu                                      |     Yes      |  [ ]   |
| 85  | COMP-085 | Header                                        | components/header                                              |     Yes      |  [ ]   |
| 86  | COMP-086 | HiddenInput                                   | components/hidden-input                                        |      No      |  [ ]   |
| 87  | COMP-087 | Hint                                          | components/hint                                                |     Yes      |  [ ]   |
| 88  | COMP-088 | HintText                                      | components/hint-text                                           |      No      |  [ ]   |
| 89  | COMP-089 | HolyGrailLayout                               | components/holy-grail-layout                                   |     Yes      |  [ ]   |
| 90  | COMP-090 | HoverCard                                     | components/hover-card                                          |      No      |  [ ]   |
| 91  | COMP-091 | Icon                                          | components/icon                                                |     Yes      |  [ ]   |
| 92  | COMP-092 | Image                                         | components/image                                               |     Yes      |  [ ]   |
| 93  | COMP-093 | ImageFileInput                                | components/image-input                                         |      No      |  [ ]   |
| 94  | COMP-094 | InformationCallout                            | components/information-callout                                 |      No      |  [ ]   |
| 95  | COMP-095 | Input                                         | components/input                                               |      No      |  [ ]   |
| 96  | COMP-096 | InsetText                                     | components/inset-text                                          |     Yes      |  [ ]   |
| 97  | COMP-097 | KanbanTable                                   | components/kanban-board                                        |      No      |  [ ]   |
| 98  | COMP-098 | Label                                         | components/label                                               |     Yes      |  [ ]   |
| 99  | COMP-099 | Listbox                                       | components/listbox                                             |      No      |  [ ]   |
| 100 | COMP-100 | MeasurementInstanceInput                      | components/measurement-instance-input                          |      No      |  [ ]   |
| 101 | COMP-101 | MeasurementInstanceView                       | components/measurement-instance-view                           |      No      |  [ ]   |
| 102 | COMP-102 | MeasurementSystemInput                        | components/measurement-system-input                            |      No      |  [ ]   |
| 103 | COMP-103 | MeasurementSystemView                         | components/measurement-system-view                             |      No      |  [ ]   |
| 104 | COMP-104 | MeasurementUnitInput                          | components/measurement-unit-input                              |      No      |  [ ]   |
| 105 | COMP-105 | MeasurementUnitView                           | components/measurement-unit-view                               |      No      |  [ ]   |
| 106 | COMP-106 | MedicalHighlightBox                           | components/medical-highlight-box                               |      No      |  [ ]   |
| 107 | COMP-107 | MedicalRecordRedBox.md                        | components/medical-patient-banner-danger-box                   |      No      |  [ ]   |
| 108 | COMP-108 | Menu                                          | components/menu                                                |      No      |  [ ]   |
| 109 | COMP-109 | Menubar                                       | components/menubar                                             |      No      |  [ ]   |
| 110 | COMP-110 | Meter                                         | components/meter                                               |      No      |  [ ]   |
| 111 | COMP-111 | MonthInput                                    | components/month-input                                         |      No      |  [ ]   |
| 112 | COMP-112 | NavigationMenu                                | components/navigation-menu                                     |      No      |  [ ]   |
| 113 | COMP-113 | NetPromotorScoreRatingPicker                  | components/net-promoter-score-picker                           |      No      |  [ ]   |
| 114 | COMP-114 | NetPromotorScoreRatingView                    | components/net-promoter-score-view                             |      No      |  [ ]   |
| 115 | COMP-115 | Notification                                  | components/notification                                        |     Yes      |  [ ]   |
| 116 | COMP-116 | NumberInput                                   | components/number-input                                        |      No      |  [ ]   |
| 117 | COMP-117 | Option                                        | components/option                                              |      No      |  [ ]   |
| 118 | COMP-118 | Pagination                                    | components/pagination                                          |     Yes      |  [ ]   |
| 119 | COMP-119 | Panel                                         | components/panel                                               |     Yes      |  [ ]   |
| 120 | COMP-120 | PasswordInput                                 | components/password-input                                      |      No      |  [ ]   |
| 121 | COMP-121 | PhoneNumberInput                              | components/phone-number-input                                  |      No      |  [ ]   |
| 122 | COMP-122 | TelLink                                       | components/phone-number-view                                   |      No      |  [ ]   |
| 123 | COMP-123 | PinInput                                      | components/pin-input                                           |      No      |  [ ]   |
| 124 | COMP-124 | Popover                                       | components/popover                                             |     Yes      |  [ ]   |
| 125 | COMP-125 | Popup                                         | components/popup                                               |     Yes      |  [ ]   |
| 126 | COMP-126 | PostalCodeInput                               | components/postal-code-input                                   |      No      |  [ ]   |
| 127 | COMP-127 | PostalCodeView                                | components/postal-code-view                                    |      No      |  [ ]   |
| 128 | COMP-128 | Progress                                      | components/progress-bar                                        |      No      |  [ ]   |
| 129 | COMP-129 | ProgressCircle                                | components/progress-circle                                     |      No      |  [ ]   |
| 130 | COMP-130 | ProgressSpinner                               | components/progress-spinner                                    |      No      |  [ ]   |
| 131 | COMP-131 | QrCode                                        | components/qr-code                                             |      No      |  [ ]   |
| 132 | COMP-132 | RadioButton                                   | components/radio-button                                        |      No      |  [ ]   |
| 133 | COMP-133 | RadioGroup                                    | components/radio-group                                         |      No      |  [ ]   |
| 134 | COMP-134 | RadioInput                                    | components/radio-input                                         |      No      |  [ ]   |
| 135 | COMP-135 | RedAmberGreenStatusPicker                     | components/red-amber-green-picker                              |      No      |  [ ]   |
| 136 | COMP-136 | RedAmberGreenStatusView                       | components/red-amber-green-view                                |      No      |  [ ]   |
| 137 | COMP-137 | RangeCalendar                                 | components/range-calendar                                      |      No      |  [ ]   |
| 138 | COMP-138 | RangeInput                                    | components/range-input                                         |      No      |  [ ]   |
| 139 | COMP-139 | RatingGroup                                   | components/rating-group                                        |      No      |  [ ]   |
| 140 | COMP-140 | RedAmberGreenStatus                           | components/red-amber-green-status                              |     Yes      |  [ ]   |
| 141 | COMP-141 | RedOrangeYellowGreenBlueStatus                | components/red-orange-yellow-green-blue-indicator-status       |     Yes      |  [ ]   |
| 142 | COMP-142 | ResetInput                                    | components/reset-input                                         |      No      |  [ ]   |
| 143 | COMP-143 | Resizable                                     | components/resizable                                           |      No      |  [ ]   |
| 144 | COMP-144 | ReviewDate                                    | components/review-date                                         |      No      |  [ ]   |
| 145 | COMP-145 | RedOrangeYellowGreenBlueStatusPicker          | components/red-orange-yellow-green-blue-status-select          |      No      |  [ ]   |
| 146 | COMP-146 | RedOrangeYellowGreenBlueStatusView            | components/red-orange-yellow-green-blue-view                   |      No      |  [ ]   |
| 147 | COMP-147 | ScrollArea                                    | components/scroll-area                                         |      No      |  [ ]   |
| 148 | COMP-148 | ScrollBar                                     | components/scrollbar                                           |     Yes      |  [ ]   |
| 149 | COMP-149 | SearchInput                                   | components/search-input                                        |      No      |  [ ]   |
| 150 | COMP-150 | SegmentGroup                                  | components/segment-group                                       |      No      |  [ ]   |
| 151 | COMP-151 | Select                                        | components/select                                              |     Yes      |  [ ]   |
| 152 | COMP-152 | SelectWithExtras                              | components/select-with-extras                                  |      No      |  [ ]   |
| 153 | COMP-153 | Separator                                     | components/separator                                           |      No      |  [ ]   |
| 154 | COMP-154 | Sheet                                         | components/sheet                                               |      No      |  [ ]   |
| 155 | COMP-155 | Sidebar                                       | components/sidebar                                             |      No      |  [ ]   |
| 156 | COMP-156 | SignaturePad                                  | components/signature-pad                                       |      No      |  [ ]   |
| 157 | COMP-157 | Skeleton                                      | components/skeleton                                            |      No      |  [ ]   |
| 158 | COMP-158 | SkipLink                                      | components/skip-link                                           |     Yes      |  [ ]   |
| 159 | COMP-159 | SlideOutDrawer                                | components/slide-out-drawer                                    |     Yes      |  [ ]   |
| 160 | COMP-160 | Slider                                        | components/slider                                              |     Yes      |  [ ]   |
| 161 | COMP-161 | Sonner                                        | components/sonner                                              |      No      |  [ ]   |
| 162 | COMP-162 | Sparkline                                     | components/sparkline                                           |     Yes      |  [ ]   |
| 163 | COMP-163 | Spinner                                       | components/spinner                                             |     Yes      |  [ ]   |
| 164 | COMP-164 | Splitter                                      | components/splitter                                            |      No      |  [ ]   |
| 165 | COMP-165 | Steps                                         | components/steps                                               |      No      |  [ ]   |
| 166 | COMP-166 | SubmitInput                                   | components/submit-input                                        |      No      |  [ ]   |
| 167 | COMP-167 | SummaryList                                   | components/summary-list                                        |     Yes      |  [ ]   |
| 168 | COMP-168 | SwitchInput                                   | components/switch-input                                        |      No      |  [ ]   |
| 169 | COMP-169 | Tab                                           | components/tab                                                 |     Yes      |  [ ]   |
| 170 | COMP-170 | TabBar                                        | components/tab-bar                                             |      No      |  [ ]   |
| 171 | COMP-171 | Table                                         | components/table                                               |     Yes      |  [ ]   |
| 172 | COMP-172 | TableOfContentsList                           | components/table-of-contents-list                              |     Yes      |  [ ]   |
| 173 | COMP-173 | Tag                                           | components/tag                                                 |      No      |  [ ]   |
| 174 | COMP-174 | TagGroup                                      | components/tag-group                                           |      No      |  [ ]   |
| 175 | COMP-175 | TagInput                                      | components/tag-input                                           |      No      |  [ ]   |
| 176 | COMP-176 | TaskList                                      | components/task-list                                           |     Yes      |  [ ]   |
| 177 | COMP-177 | TelInput                                      | components/tel-input                                           |      No      |  [ ]   |
| 178 | COMP-178 | TextInput                                     | components/text-input                                          |      No      |  [ ]   |
| 179 | COMP-179 | Textarea                                      | components/textarea                                            |     Yes      |  [ ]   |
| 180 | COMP-180 | Textfield                                     | components/textfield                                           |      No      |  [ ]   |
| 181 | COMP-181 | ThemeSelect                                   | components/theme-select                                        |     Yes      |  [ ]   |
| 182 | COMP-182 | ThemePicker                                   | components/theme-picker                                        |      No      |  [ ]   |
| 183 | COMP-183 | ThemeView                                     | components/theme-view                                          |      No      |  [ ]   |
| 184 | COMP-184 | TimeInput                                     | components/time-input                                          |      No      |  [ ]   |
| 185 | COMP-185 | TimePickerInput                               | components/time-picker                                         |     Yes      |  [ ]   |
| 186 | COMP-186 | Timeline                                      | components/timeline                                            |     Yes      |  [ ]   |
| 187 | COMP-187 | Timer                                         | components/timer                                               |      No      |  [ ]   |
| 188 | COMP-188 | Toast                                         | components/toast                                               |      No      |  [ ]   |
| 189 | COMP-189 | Toggle                                        | components/toggle                                              |      No      |  [ ]   |
| 190 | COMP-190 | ToggleGroup                                   | components/toggle-group                                        |      No      |  [ ]   |
| 191 | COMP-191 | Tooltip                                       | components/tooltip                                             |     Yes      |  [ ]   |
| 192 | COMP-192 | Tour                                          | components/tour                                                |      No      |  [ ]   |
| 193 | COMP-193 | TreeNav                                       | components/tree-nav                                            |     Yes      |  [ ]   |
| 194 | COMP-194 | TreeNavList                                   | components/tree-view                                           |      No      |  [ ]   |
| 195 | COMP-195 | UnitedKingdomNationalHealthServiceNumberInput | components/united-kingdom-national-health-service-number-input |      No      |  [ ]   |
| 196 | COMP-196 | UnitedKingdomNationalHealthServiceNumberView  | components/united-kingdom-national-health-service-number-view  |      No      |  [ ]   |
| 197 | COMP-197 | UnitedStatesSocialSecurityNumberInput         | components/united-states-social-security-number-input          |      No      |  [ ]   |
| 198 | COMP-198 | UnitedStatesSocialSecurityNumberView          | components/united-states-social-security-number-view           |      No      |  [ ]   |
| 199 | COMP-199 | UrlInput                                      | components/url-input                                           |      No      |  [ ]   |
| 200 | COMP-200 | WarningCallout                                | components/warning-callout                                     |     Yes      |  [ ]   |
| 201 | COMP-201 | WeekInput                                     | components/week-input                                          |      No      |  [ ]   |

---

## Summary

- **Infrastructure tasks**: 4
- **Component tasks**: 201
- **Total tasks**: 205
- **Components with existing docs**: 67
- **Components needing docs**: 134
