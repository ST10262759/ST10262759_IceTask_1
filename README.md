# Notification Factory Pattern Implementation

This project demonstrates the Factory Design Pattern using a notification system example in C#.

## Class Diagram
![image](https://github.com/user-attachments/assets/ed5c14bd-040a-4c16-9254-4055e2acfb2c)

## Overview

The Factory Design Pattern is a creational pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. This implementation showcases a notification system with three different notification types:

- Email Notification
- SMS Notification
- Push Notification

## Project Structure

- **INotification.cs**: Interface that defines the common behavior for all notification types
- **EmailNotification.cs**: Implementation for sending email notifications
- **SMSNotification.cs**: Implementation for sending SMS notifications
- **PushNotification.cs**: Implementation for sending push notifications
- **NotificationFactory.cs**: Factory class that creates the appropriate notification object based on the requested channel
- **Program.cs**: Client code that demonstrates the usage of the factory pattern

## How It Works

The client code requests notification objects from the NotificationFactory by specifying the notification channel ("email", "sms", or "push"). The factory creates and returns the appropriate notification object, which the client then uses to send messages without needing to know the specific implementation details.

## Benefits

1. **Decoupling**: Client code is decoupled from concrete notification implementations
2. **Extensibility**: Easy to add new notification types without modifying existing code
3. **Single Responsibility**: Each class has a well-defined role and responsibility
4. **Open/Closed Principle**: The system is open for extension but closed for modification

## Running the Application

1. Open the solution in Visual Studio
2. Build the solution (Ctrl+Shift+B)
3. Run the application (F5)
4. Observe the console output showing different notification types being created and used

## Extending the Application

To add a new notification type:

1. Create a new class that implements the INotification interface
2. Add a new case to the NotificationFactory's CreateNotification method
3. The client code doesn't need to change to use the new notification type
