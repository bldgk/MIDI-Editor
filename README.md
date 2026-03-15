# MIDI Editor

A sheet music editor with note rendering, multi-track support, and instrument selection. Built with C# WinForms (2015).

## Features

- Visual note editing on a rendered staff (treble clef)
- Note types: whole, half, quarter, eighth, sixteenth + corresponding pauses
- Multi-track compositions with time signatures
- Instruments: Guitar (acoustic, electric, bass), Piano, Saxophone, Drums
- Composition and performer management
- DataContract serialization (save/load projects)

## Architecture

```
MIDI Library/           ← Core music model (48 classes)
├── Note.cs             ← Abstract note with pitch, octave, duration, GDI+ rendering
├── NoteWhole/Half/Quarter/Eighth/Sixteenth.cs
├── PauseWhole/Half/Quarter/Sixteenth.cs
├── Line.cs             ← Staff line positions (C1 through B3 + sharps/flats)
├── Staff.cs            ← Staff layout constants
├── Track.cs            ← Ordered list of notes, instrument, time signature
├── Composition.cs      ← Multiple tracks
├── Instrument.cs       ← Guitar, Piano, Saxophone, Drums
├── Performer.cs        ← Artist metadata
├── WAVEHeader.cs       ← Audio format support
└── Base.cs             ← Shared persistence (DataContract XML serialization)

MIDI Editor V2.0/       ← WinForms GUI
├── FormMain.cs         ← Main window with staff rendering
├── FNoteEdit.cs        ← Note editing dialog
├── FormCreateTrack.cs  ← Track creation with instrument selection
├── FChooseComp.cs      ← Composition browser
├── FAddPerformer.cs    ← Performer management
└── FSongs.cs           ← Song list
```

## Tech

- C# / .NET Framework
- WinForms + GDI+ (BufferedGraphics for note rendering)
- DataContract XML serialization
