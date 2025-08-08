# 🧰 WarQuest – Asset Generation & AI Tools

This document outlines all the AI tools and resources used for creating models, textures, and animations for **WarQuest**. As the project is developed by a solo programmer, most graphical content is generated using external tools (mostly free).

---

## 🧠 AI Tools Used

### 🔷 3D Models

* **Scenario-GPT3D** – AI-based 3D model generator (ideal for sci-fi & tactical assets)
* **Threed.io** – Simple shape generator for low-poly game models
* **Polycam** – Real-world object scanner (free photogrammetry)

### 🔶 Textures

* **AmbientCG** – 100% free PBR textures
* **Poly Haven** – High-quality, seamless 4K PBR materials
* **Artbreeder** – Image generation and manipulation (for faces, icons, or base texture maps)

### 🟢 Animations

* **Mixamo** – Adobe tool for animation + auto-rigging (free, fast)
* **DeepMotion** – AI motion capture (limited free plan)

---

## 🎯 Example Prompts

You can use these in supported platforms when generating assets:

### 🧊 3D Model Prompt Example:

```
"Post-apocalyptic sci-fi soldier wearing armor, low-poly, helmet, clean topology, game-ready"
```

### 🌄 Texture Prompt Example:

```
"Realistic ground terrain, dry cracked soil, seamless, PBR, 2K"
```

### 🏃 Animation Prompt Example:

```
"Character running with rifle, idle crouch with weapon, melee slash animation"
```

---

## 📥 Export Guidelines

* Models should be exported in `.fbx` or `.obj`
* Textures in `.png` with maps: Albedo, Normal, Roughness, Metallic (if available)
* Animations should be `.fbx` with rigging if not using Unity’s Animator tools

---

## 🗂️ Directory Recommendation (within Unity project)

```
Assets/
├── Models/
├── Textures/
├── Animations/
├── Materials/
├── AI_Generated/
│   ├── Models/
│   ├── Textures/
│   └── Animations/
```

---

## 🤝 Credits

Please credit all external tools and marketplaces in your project documentation.
