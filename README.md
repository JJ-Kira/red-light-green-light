# Red Light, Green Light - An Eye-Tracking VR Game

## **Overview**
This project is a **Unity 6 game** designed to showcase **eye-tracking as a natural input method** for VR gaming. Inspired by the classic "Red Light, Green Light" game, it features both **PC and SteamVR** versions with different input methods:

- **PC Version (Non-VR)** - The player is the **doll**, detecting NPC movement using **mouse input**.
- **SteamVR Version** - Supports **solo play & multiplayer**, where the doll uses **eye-tracking (EyeTrackVR)** to stop moving players.

The project is structured to be **versatile**, handling both VR and non-VR within a **unified codebase**.

---

## **Planned Features**
### **Core Mechanics**
- The **doll-player** can trigger movement phases by:
  - Holding a button.
  - Turning around physically (VR only).
  - Using a microphone (optional, for voice-recited cues).
- **Runners (NPCs/Players)** must freeze **when observed by the doll**.
- The **doll wins** if no runner reaches the finish line.
- **Scoring System**:
  - **Doll:** Earns points for correctly detecting movement (+) and loses points for false positives (-).
  - **Runners:** Gain points for successfully reaching the goal.

### **Input Methods**
- **PC (Non-VR)** - Uses **mouse input** to track NPC movements.
- **VR (SteamVR)** - Uses **eye-tracking (via EyeTrackVR)** for detection.
- **Optional Physics-Based Movement** (future implementation).

### **Multiplayer Support (VR Mode)**
- Implemented using **Mirror Networking**.
- One player acts as the **doll**, others as **runners**.

---

## **Development Plan**
### **Phase 1: Core Setup** (🟢 **Current Phase**)
- [ ] **Set up GitHub repository**.
- [ ] **Configure Unity 6 project** with:
  - XR Plugin Management (for OpenXR/SteamVR).
  - Input System (to support both PC & VR modes).
- [ ] **Implement core game loop** (basic Red Light, Green Light logic).

### **Phase 2: Eye-Tracking & Gameplay Implementation**
- [ ] Integrate **EyeTrackVR** for gaze-based player detection.
- [ ] Implement **game mode switching** (PC vs. VR).
- [ ] Develop **doll and runner behaviors**.

### **Phase 3: Multiplayer & Advanced Mechanics**
- [ ] Add **Mirror networking** for online multiplayer.
- [ ] Implement **scoring system** and refine movement mechanics.
- [ ] Optimize **VR performance & physics interactions**.

### **Phase 4: Polish & Testing**
- [ ] Implement **UI and tutorial elements**.
- [ ] Playtesting and debugging.
- [ ] **Document findings** for thesis evaluation.

---

## **Technologies Used**
- **Unity 6** (Game Engine)
- **SteamVR & OpenXR** (VR Support)
- **EyeTrackVR** (Open-source eye-tracking solution)
- **Mirror** (Multiplayer Networking)

---

**License:** TBD (Possibly MIT or similar).

---

## **References & Thesis Context**
This game serves as a **practical demonstration** of eye-tracking integration in VR gaming. It is part of a research study exploring how **natural gaze input** can be used as an **alternative interaction method** in game design.

Further details on the technical approach and findings will be documented in the thesis.

---

**Author:** Julia Szczuczko
