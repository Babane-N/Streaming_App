# Streaming_App
### This project simulates a Streaming Platform where users can access and switch between various types of media content such as Movies, Music, Sports, Podcasts, and Videos. Based on their subscription plan, users gain access to different streaming packages.

### 🎯 Project Goals
Provide a dynamic and extensible media streaming experience

Apply design patterns to solve real-world software design challenges

Offer flexibility for users to change streaming content types at runtime

Manage subscription types cleanly and efficiently

### 🧠 Design Patterns Used
🧩 Strategy Pattern
We implemented the Strategy Pattern to allow users to switch between stream categories at runtime.

Example:
A user can dynamically switch from watching Movies to streaming Sports, without restarting the session or application logic.

✅ Benefits:
Promotes open/closed principle

Makes it easy to add new streaming types (e.g., eBooks, Live TV)

#### Isolates streaming logic per category

### 🏭 Factory Pattern
We used the Factory Pattern to create and manage different subscription packages:

Deluxe Package

Access to all content: Movies, Sports, Music, Podcasts, and Videos

Essential Package

Limited access to selected categories (e.g., Music & Podcasts only)

✅ Benefits:
Simplifies object creation based on user choice

Makes it easy to add more subscription levels in the future

Ensures encapsulation of subscription logic

### 📦 Features
🔄 Runtime switching between streaming categories

🧾 Subscription-based content access

🧠 Scalable architecture using design patterns

🎛️ Easy integration of future features like parental controls or content recommendations

### UML Diagrams

#### Strategic Pattern

![Picture14](https://github.com/user-attachments/assets/600862d8-e5ed-442e-88c0-7e9325c32a78)

#### Factory Pattern

![Picture15](https://github.com/user-attachments/assets/3b33f5af-bd1d-4411-8cd2-2903f8e2a488)

