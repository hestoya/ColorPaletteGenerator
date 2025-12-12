# Color Palette Generator (Blazor Web App)

## 📜 Overview

This **Color Palette Generator** is a Blazor Web App that generates random RGB color palettes and converts them to HEX. It is designed to help users discover color combinations for their design projects.

The app is based on a tutorial I followed [here](https://www.youtube.com/watch?v=lZA2hKx3SEY&t=827s). I built it to practice working with Blazor Web Apps and enhance my understanding of web development.

---

## 🔧 Current Functionality

- **Random Color Generation**: Generates a palette of 4 random RGB colors.
- **RGB to HEX Conversion**: Converts the generated RGB colors to their HEX equivalents.
- **Basic UI**: Displays the generated colors with their respective RGB and HEX codes.
- **Palette Regeneration**: Regenerate a new random palette on click.

---

## 🚀 Features to Be Added

1. **Lock/Unlock Colors**: Ability to lock specific colors so they won't change when the palette is regenerated.
2. **Color Count Adjustment**: Let users adjust the number of colors in the palette (e.g., 3–8 colors).
3. **Copy to Clipboard**: Add a button to easily copy the color codes (RGB/HEX) to the clipboard.
4. **Save Palettes Locally**: Save generated color palettes in the browser’s local storage for future reference.
5. **Color Picker Tool**: Allow users to adjust one or more colors manually with a color picker.
6. **Color Harmonies**: Automatically generate color harmonies like complementary, analogous, triadic, etc.
7. **Accessibility Checker**: Check if the colors have enough contrast for text legibility (WCAG standards).
8. **Color Visualization**: Display the generated colors in various UI elements (buttons, background, etc.).
9. **Export Options**: Enable users to export palettes in various formats like PNG, CSS variables, SCSS, or JSON.
10. **Color Naming**: Automatically assign names to the colors in the palette (e.g., "Sea Green", "Midnight Blue").
11. **Dark Mode Toggle**: Allow users to switch between light and dark themes.
12. **Shareable URLs**: Generate and share a URL that encodes the current color palette.

---


## 🛠️ Clone and Run the App

### Prerequisites

Before you clone and run this project, make sure you have the following installed:

- **Visual Studio 2022** or **Visual Studio Code**
- **.NET SDK** (version 6.0 or higher)  
  Download and install it from [here](https://dotnet.microsoft.com/download).
  
If you're using **Visual Studio**, make sure you have the **Blazor WebAssembly** template installed. You can install it via the Visual Studio Installer when setting up your Visual Studio installation.

---

### 1. **Clone the Repository**

To get started, clone this repository to your local machine using Git. Open your terminal or command prompt and run:

```bash
git clone https://github.com/hestoya/ColorPaletteGenerator.git
cd ColorPaletteGenerator
