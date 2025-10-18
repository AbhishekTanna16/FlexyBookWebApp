# FlexybookWebApp

A Blazor WebAssembly application that provides a modern interface for viewing and managing location data, built with .NET 8.

## Overview

FlexybookWebApp is a custom-designed Blazor application created from scratch without using pre-developed component libraries or CSS frameworks (like Bootstrap or Tailwind). The app allows users to browse locations, view detailed information about each location, and manage favorites.

## Features Implemented

### 1. Location Browsing System
- Dynamic sidebar navigation for easy access to all locations
- Auto-selection of first location when application loads
- Real-time location filtering

### 2. Location Details View
- Comprehensive display of location information including:
  - Name, address, contact information
  - Operating status (open/closed) with visual indicators
  - Favorite toggling functionality
  - Opening hours organized by service type (Restaurant, Takeaway, etc.)
  
### 3. Media Gallery
- Horizontal scrolling image gallery with custom navigation controls
- Image selection and highlighting
- Responsive image sizing and layout
- Author notes and metadata display for selected images

### 4. Custom UI Components
- Hand-crafted responsive sidebar with visual effects
- Custom tab system for viewing different service hours
- Status indicators with color coding
- Favorite toggling with animation

### 5. Responsive Layout
- Mobile-friendly design that adapts to different screen sizes
- Proper content layout on all devices
- Touch-friendly interactions

## Technical Implementation

### Architecture
- Built with Blazor WebAssembly (.NET 8)
- Clean separation of concerns:
  - Models: Data structures (LocationModel, OpeningHour)
  - Services: Data access and business logic (ILocationService, LocationService)
  - Components: UI elements and pages
  - CSS: Custom styling without frameworks

### Coding Style
- **C# Standards**:
  - Strong typing with nullable reference types
  - Interface-driven development for testability
  - Asynchronous patterns where appropriate
  - Clean parameter naming and method organization
  
- **Component Design**:
  - Single responsibility principle for components
  - Parameter passing between components
  - Proper event handling and state management
  - Component lifecycle management

- **CSS Approach**:
  - Custom CSS without frameworks
  - BEM-like naming conventions
  - Responsive design with media queries
  - CSS variables for consistent theming
  - Transitions and animations for better UX

## Setup and Running the Application

### Prerequisites
- .NET 8 SDK
- A modern web browser

### Running Locally
1. Clone the repository:
   git clone https://github.com/yourusername/FlexybookWebApp.git

2. Navigate to the project directory:
   cd FlexybookWebApp


3. Run the application:
   dotnet run


4. Open your browser and navigate to `https://localhost:5001`

## Development Approach

The application was built following these principles:
- Mobile-first responsive design
- Component-based architecture
- Clean, maintainable CSS without frameworks
- Accessibility considerations
- Progressive enhancement

## Future Enhancements
- User authentication and personalization
- Location search and filtering
- Map integration
- Booking functionality
- Dark mode theme.

   