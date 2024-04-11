# gamf_gameDev_lecture_07

UI elemek (...UI)
Canvas - egy szülő panel
Image - egy olyan panel amely egy képet tud hordozni
Text - A VS labelje itt

UI Control elemek:
Button, slider, inputfield

A root parent mindig egy canvas kell legyen, mert szülő gyermek hierarchiával vannak egymáshoz rendelve az elemek.

1. Canvas:
   - Kötetlező parent elem
   - Transform helyett RectTransform
  
  Canvas/RenderMode:
  - Screen Space Overlay
  - Screen Space Camera
  - World Space (nincs overlay, a canvas belép a világba, méretezhető lesz)
