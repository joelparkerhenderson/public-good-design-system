"use client";

import { useState } from "react";
import TabBar from "@pgds/TabBar";
import TabBarButton from "@pgds/TabBarButton";
import AccordionNav from "@pgds/AccordionNav";
import AccordionNavList from "@pgds/AccordionNavList";
import AccordionNavListItem from "@pgds/AccordionNavListItem";
import Badge from "@pgds/Badge";

interface Notification {
    id: number;
    title: string;
    message: string;
    type: "info" | "warning" | "error";
    read: boolean;
}

const notifications: Notification[] = [
    { id: 1, title: "Welcome", message: "Thanks for signing up!", type: "info", read: true },
    { id: 2, title: "Update available", message: "Version 2.0 is ready.", type: "info", read: false },
    { id: 3, title: "Disk space low", message: "Less than 10% remaining.", type: "warning", read: false },
    { id: 4, title: "Build failed", message: "CI pipeline error on main.", type: "error", read: false },
];

export default function TabbedInterfacePage() {
    const [activeTab, setActiveTab] = useState("all");
    const unreadCount = notifications.filter((n) => !n.read).length;

    const filtered = activeTab === "all"
        ? notifications
        : notifications.filter((n) => !n.read);

    return (
        <main>
            <h1>Notifications</h1>

            <TabBar label="Notification filters">
                <TabBarButton
                    selected={activeTab === "all"}
                    controls="all-panel"
                    onClick={() => setActiveTab("all")}
                >
                    All
                </TabBarButton>
                <TabBarButton
                    selected={activeTab === "unread"}
                    controls="unread-panel"
                    onClick={() => setActiveTab("unread")}
                >
                    Unread <Badge type="warning">{unreadCount}</Badge>
                </TabBarButton>
            </TabBar>

            <div id={activeTab === "all" ? "all-panel" : "unread-panel"}>
                <AccordionNav label="Notification details">
                    <AccordionNavList>
                        {filtered.map((item) => (
                            <AccordionNavListItem key={item.id}>
                                <h3>
                                    {item.title}
                                    {!item.read && <Badge type="info">New</Badge>}
                                    <Badge type={item.type === "error" ? "error" : item.type === "warning" ? "warning" : "default"}>
                                        {item.type}
                                    </Badge>
                                </h3>
                                <p>{item.message}</p>
                            </AccordionNavListItem>
                        ))}
                    </AccordionNavList>
                </AccordionNav>
            </div>
        </main>
    );
}
