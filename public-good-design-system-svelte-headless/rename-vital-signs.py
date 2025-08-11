#!/usr/bin/env python3
"""Rename 24 vital sign components: replace text in files and rename files."""
import os

COMP_DIR = '/Users/jph/git/joelparkerhenderson/public-good-design-system/public-good-design-system-svelte-headless/components'

# Define all rename pairs: (old_pascal, new_pascal, old_kebab, new_kebab)
renames = [
    ('VitalSignBloodPressureDiastolicInput', 'VitalSignBloodPressureDiastolicAsMmhgInput', 'vital-sign-blood-pressure-diastolic-input', 'vital-sign-blood-pressure-diastolic-as-mmhg-input'),
    ('VitalSignBloodPressureDiastolicView', 'VitalSignBloodPressureDiastolicAsMmhgView', 'vital-sign-blood-pressure-diastolic-view', 'vital-sign-blood-pressure-diastolic-as-mmhg-view'),
    ('VitalSignBloodPressureSystolicInput', 'VitalSignBloodPressureSystolicAsMmhgInput', 'vital-sign-blood-pressure-systolic-input', 'vital-sign-blood-pressure-systolic-as-mmhg-input'),
    ('VitalSignBloodPressureSystolicView', 'VitalSignBloodPressureSystolicAsMmhgView', 'vital-sign-blood-pressure-systolic-view', 'vital-sign-blood-pressure-systolic-as-mmhg-view'),
    ('VitalSignBodyFatPercentageInput', 'VitalSignBodyFatAsPercentageInput', 'vital-sign-body-fat-percentage-input', 'vital-sign-body-fat-as-percentage-input'),
    ('VitalSignBodyFatPercentageView', 'VitalSignBodyFatAsPercentageView', 'vital-sign-body-fat-percentage-view', 'vital-sign-body-fat-as-percentage-view'),
    ('VitalSignBodyTemperatureCelciusInput', 'VitalSignBodyTemperatureAsCelciusInput', 'vital-sign-body-temperature-celcius-input', 'vital-sign-body-temperature-as-celcius-input'),
    ('VitalSignBodyTemperatureCelciusView', 'VitalSignBodyTemperatureAsCelciusView', 'vital-sign-body-temperature-celcius-view', 'vital-sign-body-temperature-as-celcius-view'),
    ('VitalSignCholesterolHdlMmolPerLitreInput', 'VitalSignCholesterolAsHdlMmolPerLitreInput', 'vital-sign-cholesterol-hdl-mmol-per-litre-input', 'vital-sign-cholesterol-as-hdl-mmol-per-litre-input'),
    ('VitalSignCholesterolHdlMmolPerLitreView', 'VitalSignCholesterolAsHdlMmolPerLitreView', 'vital-sign-cholesterol-hdl-mmol-per-litre-view', 'vital-sign-cholesterol-as-hdl-mmol-per-litre-view'),
    ('VitalSignCholesterolLdlMmolPerLitreInput', 'VitalSignCholesterolAsLdlMmolPerLitreInput', 'vital-sign-cholesterol-ldl-mmol-per-litre-input', 'vital-sign-cholesterol-as-ldl-mmol-per-litre-input'),
    ('VitalSignCholesterolLdlMmolPerLitreView', 'VitalSignCholesterolAsLdlMmolPerLitreView', 'vital-sign-cholesterol-ldl-mmol-per-litre-view', 'vital-sign-cholesterol-as-ldl-mmol-per-litre-view'),
    ('VitalSignHeartRateBeatsPerMinuteInput', 'VitalSignHeartRateAsBeatsPerMinuteInput', 'vital-sign-heart-rate-beats-per-minute-input', 'vital-sign-heart-rate-as-beats-per-minute-input'),
    ('VitalSignHeartRateBeatsPerMinuteView', 'VitalSignHeartRateAsBeatsPerMinuteView', 'vital-sign-heart-rate-beats-per-minute-view', 'vital-sign-heart-rate-as-beats-per-minute-view'),
    ('VitalSignHeightCmInput', 'VitalSignHeightAsCmInput', 'vital-sign-height-cm-input', 'vital-sign-height-as-cm-input'),
    ('VitalSignHeightCmView', 'VitalSignHeightAsCmView', 'vital-sign-height-cm-view', 'vital-sign-height-as-cm-view'),
    ('VitalSignRespiratoryRateBreathsPerMinuteInput', 'VitalSignRespiratoryRateAsBreathsPerMinuteInput', 'vital-sign-respiratory-rate-breaths-per-minute-input', 'vital-sign-respiratory-rate-as-breaths-per-minute-input'),
    ('VitalSignRespiratoryRateBreathsPerMinuteView', 'VitalSignRespiratoryRateAsBreathsPerMinuteView', 'vital-sign-respiratory-rate-breaths-per-minute-view', 'vital-sign-respiratory-rate-as-breaths-per-minute-view'),
    ('VitalSignVO2MaxMlPerKgPerMinuteInput', 'VitalSignVO2MaxAsMlPerKgPerMinuteInput', 'vital-sign-vo2-max-ml-per-kg-per-minute-input', 'vital-sign-vo2-max-as-ml-per-kg-per-minute-input'),
    ('VitalSignVO2MaxMlPerKgPerMinuteView', 'VitalSignVO2MaxAsMlPerKgPerMinuteView', 'vital-sign-vo2-max-ml-per-kg-per-minute-view', 'vital-sign-vo2-max-as-ml-per-kg-per-minute-view'),
    ('VitalSignWaistCircumferenceCmInput', 'VitalSignWaistCircumferenceAsCmInput', 'vital-sign-waist-circumference-cm-input', 'vital-sign-waist-circumference-as-cm-input'),
    ('VitalSignWaistCircumferenceCmView', 'VitalSignWaistCircumferenceAsCmView', 'vital-sign-waist-circumference-cm-view', 'vital-sign-waist-circumference-as-cm-view'),
    ('VitalSignWeightKgInput', 'VitalSignWeightAsKgInput', 'vital-sign-weight-kg-input', 'vital-sign-weight-as-kg-input'),
    ('VitalSignWeightKgView', 'VitalSignWeightAsKgView', 'vital-sign-weight-kg-view', 'vital-sign-weight-as-kg-view'),
]

# Sort renames by length of old_pascal descending to replace longer names first
renames.sort(key=lambda x: -len(x[0]))

# Collect all VitalSign files
all_files = [f for f in os.listdir(COMP_DIR) if f.startswith('VitalSign')]
print(f'Found {len(all_files)} VitalSign files')

# Step 1: Do text replacements in ALL VitalSign files
for fname in sorted(all_files):
    fpath = os.path.join(COMP_DIR, fname)
    with open(fpath, 'r') as f:
        content = f.read()

    original = content
    for old_pascal, new_pascal, old_kebab, new_kebab in renames:
        content = content.replace(old_pascal, new_pascal)
        content = content.replace(old_kebab, new_kebab)

    if content != original:
        with open(fpath, 'w') as f:
            f.write(content)
        print(f'  Updated content: {fname}')

# Step 2: Rename files
for old_pascal, new_pascal, old_kebab, new_kebab in renames:
    for ext in ['.svelte', '.test.ts', '.md']:
        old_name = old_pascal + ext
        new_name = new_pascal + ext
        old_path = os.path.join(COMP_DIR, old_name)
        new_path = os.path.join(COMP_DIR, new_name)
        if os.path.exists(old_path):
            os.rename(old_path, new_path)
            print(f'  Renamed: {old_name} -> {new_name}')
        else:
            print(f'  WARNING: {old_name} not found (may already be renamed)')

print('Done with component files!')
