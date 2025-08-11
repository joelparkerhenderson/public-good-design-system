<script setup lang="ts">
import { ref, computed } from "vue";

interface Milestone {
    date: string;
    heading: string;
    title: string;
    description: string;
    status: "success" | "warning" | "info" | "default";
    statusLabel: string;
}

const milestones: Milestone[] = [
    {
        date: "2025-01-10", heading: "January 10, 2025",
        title: "Project Kickoff", description: "Initial planning session and team onboarding.",
        status: "success", statusLabel: "Completed",
    },
    {
        date: "2025-03-01", heading: "March 1, 2025",
        title: "Alpha Release", description: "Core features shipped to internal testers.",
        status: "success", statusLabel: "Completed",
    },
    {
        date: "2025-06-15", heading: "June 15, 2025",
        title: "Beta Launch", description: "Public beta with feedback collection enabled.",
        status: "warning", statusLabel: "In Progress",
    },
    {
        date: "2025-09-01", heading: "September 1, 2025",
        title: "General Availability", description: "Production release to all customers.",
        status: "default", statusLabel: "Planned",
    },
];

const filterStart = ref("2025-01-01");
const filterEnd = ref("2025-12-31");

const filtered = computed(() =>
    milestones.filter((m) => m.date >= filterStart.value && m.date <= filterEnd.value)
);
</script>

<template>
    <main class="page-wrapper">
        <h1>Project History</h1>

        <Card heading="Filter by Date Range">
            <DateRange
                label="Milestone date range"
                :start="filterStart"
                :end="filterEnd"
            />
            <div class="date-field">
                <Field label="From">
                    <DateInput label="Start date" v-model="filterStart" />
                </Field>
                <Field label="To">
                    <DateInput label="End date" v-model="filterEnd" />
                </Field>
            </div>
        </Card>

        <ReviewDate label="Last updated" datetime="2025-06-20">
            Last updated: June 20, 2025
        </ReviewDate>

        <h2>Milestones</h2>
        <TimelineList label="Project milestones">
            <TimelineListItem v-for="m in filtered" :key="m.date" :datetime="m.date" :heading="m.heading">
                <Card :heading="m.title">
                    <Badge :type="m.status">{{ m.statusLabel }}</Badge>
                    <p>{{ m.description }}</p>
                    <SummaryList :label="`${m.title} details`">
                        <SummaryListItem>
                            <dt>Target Date</dt>
                            <dd>{{ m.heading }}</dd>
                        </SummaryListItem>
                        <SummaryListItem>
                            <dt>Status</dt>
                            <dd>{{ m.statusLabel }}</dd>
                        </SummaryListItem>
                    </SummaryList>
                </Card>
            </TimelineListItem>
        </TimelineList>

        <h2>Project Summary</h2>
        <SummaryList label="Overall project summary">
            <SummaryListItem>
                <dt>Total Milestones</dt>
                <dd>{{ milestones.length }}</dd>
            </SummaryListItem>
            <SummaryListItem>
                <dt>Completed</dt>
                <dd>{{ milestones.filter((m) => m.status === 'success').length }}</dd>
            </SummaryListItem>
            <SummaryListItem>
                <dt>In Progress</dt>
                <dd>{{ milestones.filter((m) => m.status === 'warning').length }}</dd>
            </SummaryListItem>
            <SummaryListItem>
                <dt>Planned</dt>
                <dd>{{ milestones.filter((m) => m.status === 'default').length }}</dd>
            </SummaryListItem>
        </SummaryList>
    </main>
</template>
