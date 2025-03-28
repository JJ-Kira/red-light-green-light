# Red Light, Green Light - Game Design Document (GDD)

## 🎮 Game Overview
**Title:** Red Light, Green Light  
**Genre:** VR / Social / Stealth / Experimental  
**Theme:** Inspired by the traditional children's game and its modern cultural references (e.g., Squid Game) with an emphasis on gaze-controlled gameplay  
**Thesis Focus:** Showcasing natural input through EyeTrackVR (OSC) in immersive multiplayer and single-player VR environments

## 🧑‍🤝‍🧑 Target Audience
- VR enthusiasts
- Players interested in experimental mechanics
- Game devs & researchers exploring natural inputs

## 📦 Platforms & Modes
- **PC (non-VR):** Single player only (player acts as the "doll")
- **VR via SteamVR (Meta Quest 2):**
  - Single player (runners as NPCs)
  - Multiplayer (one player is the doll, others are runners)

## 🎯 Core Gameplay Loop
> TO BE FINALIZED  
Basic idea: Runners must advance when the doll is not looking. The doll uses eye-tracking to catch movement and mark runners for elimination.

### Doll Mechanics
- Gaze detection zone / cone
- Trigger red/green light phase (via button, timer, voice?)
- Score: +points per caught runner, -points for false positives?

### Runner Mechanics
- Move only during green light
- Freeze when being looked at
- Reach finish line to win / earn points

## 👁 Eye-Tracking Integration (via OSC)
- **Tool:** EyeTrackVR
- **Method:** OSC protocol (Unity integration planned)
- **Data received:** Gaze direction (horizontal/vertical angles)
- Used for:
  - Gaze-triggered freeze mechanic
  - (Optional) Head-locked foveated rendering?
  - NPC reactions in single player

## 🔧 Technical Architecture
- Unity 6 (URP)
- SteamVR plugin (Meta Quest 2 over Air Link or cable)
- OSC plugin (Unity) for EyeTrackVR
- (Planned) Networking via [FishNet / Photon Fusion / NGO]
- Mixamo NPC animations for SP prototype

## 🎨 Art & Audio Direction
- Stylized or semi-realistic (TBD)
- Iconic elements (e.g., big "doll" character, playground setting)
- 3D environment: obstacle-filled arena?
- Audio cues for red/green light phase

## 🧪 Development Timeline (Rough)
- March–April: GDD + core systems prototype (gaze detection, SP runner AI)
- May: Multiplayer systems & gaze refinement
- June: Polish, testing, thesis screenshots + video demo

## 📌 To-Do & Open Questions
- Decide final win/loss logic
- UI: gaze-based or controller?
- Multiplayer backend decision
- Doll control methods (voice, button, timer?)
- Gaze prediction or smoothing?
- Any replay/analytics features?

---

> **Next:** Fill in mechanics, implementation details, and finalize design choices as development progresses.

