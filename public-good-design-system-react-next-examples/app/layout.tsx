import type { Metadata } from "next";
import "@/assets/css/nhs.css";

export const metadata: Metadata = {
    title: "Public Good Design System — React Next Examples",
    description: "React Next.js examples of the Public Good Design System using NHS UK styles",
};

export default function RootLayout({
    children,
}: {
    children: React.ReactNode;
}) {
    return (
        <html lang="en">
            <body>{children}</body>
        </html>
    );
}
