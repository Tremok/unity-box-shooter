# 🔫 Box Shooter

A Unity first-person shooter game developed as part of the **Introduction to Game Development** course at **Michigan State University**.

The player navigates through levels, shooting projectiles at moving targets to score points before the timer runs out, focusing on first-person controls, physics-based projectiles, and game state management.

---

## 🚀 Live Demo

👉 **[Play in Browser →](https://unity-box-shooter.tremok.com)**

---

## 🎮 Gameplay

- First-person shooter with mouse-look controls
- Shoot projectiles at moving targets to earn points
- Beat each level by reaching the score threshold before time runs out
- Hitting targets can add time — or freeze the player temporarily
- Two levels with increasing challenge

---

## 🛠️ Tech Stack

- **Engine:** Unity (WebGL export)
- **Language:** C#

---

## 📚 Course Info

| Field | Details |
|---|---|
| Course | Introduction to Game Development |
| Institution | Michigan State University |
| Instructor | Brian Winn |

---

## 📁 Project Structure

> **Note:** The `Build/` folder is excluded from this repo via `.gitignore`. The WebGL build is deployed separately to Vercel. Set **Root Directory** to `Build` in your Vercel project settings.


```
/
├── Assets/
│   ├── _Scenes/         # Level scenes (Level1, Level2)
│   ├── Scripts/         # Game logic — player controller, shooter, targets, game manager
│   ├── Animations/      # Animation clips
│   ├── Audio/           # Sound effects and music
│   ├── Materials/       # Surface materials
│   ├── Prefabs/         # Reusable game objects
│   ├── Textures/        # Visual assets
│   └── Standard Assets/ # Unity standard assets
├── ProjectSettings/     # Unity project configuration
├── LICENSE
└── README.md
```

---

_Built with ❤️ as part of a structured learning path in game development._