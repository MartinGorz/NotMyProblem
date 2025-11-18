# Not My Problem

> A short, cinematic western about an old man, a dying desert town, and a life philosophy:

> **"Not my problem."**

Not My Problem is a tiny narrative-driven western made for **GitHub Game Off 2025**.  
You sit on a creaky wooden porch at sunset, cigarette in one hand, beer in the other, watching a dusty road cut through the desert.

You can’t move. You can’t fix anything.  
You can only **smoke** or **drink**… while the world slowly falls apart in front of you.

---

## 🎮 Gameplay Overview

- Each run is a **short 30-second “day”** in the life of an old cowboy.
- You sit on your porch and watch random events unfold on the road:
  - cars passing by  
  - stray animals  
  - small accidents  
  - weird shadows  
  - strange lights in the sky  
  - and, sometimes, things that really shouldn’t exist…

- Your only interactions:
  - **Take a drag from your cigarette**
  - **Take a sip from your beer**

Most of the time, the old man’s reaction is simple:

> `Not my problem.`

But as days go by, the world becomes stranger, sadder and more decayed.  
And eventually, there *is* a problem.

---

## ✨ Features

- **Cinematic western mood**
  - Slow, dusty sunset lighting
  - Old acoustic guitar and harmonica, played through a broken radio
- **Minimal input, maximal vibe**
  - Just two actions: **smoke** or **drink**
  - No HUD, no score, no quests
- **Smart Random Events**
  - Weighted random system prefers events you haven’t seen yet
  - Rare and very rare events for surprise moments and replay value
- **Progression in layers**
  - Early runs feel almost normal  
  - Later runs get gradually weirder, darker, and more surreal
- **A neighbor across the road**
  - Another old man on his own porch
  - Occasional *cheers* moments between the two  
  - Then one day, he doesn’t show up…
- **Emotional arc without dialogue**
  - Almost all storytelling is done through staging, animation, sound and timing
- **Short, replayable, streamer-friendly**
  - Perfect for “one more run” and reaction videos

---

## 🕹 Controls

*(Default – adjust to match your actual implementation)*

- **Left Click / X / Space** – Take a drag from your cigarette  
- **Right Click / B / Enter** – Take a sip of beer  
- **Esc** – Quit

There is **no menu** during a run and no pausing the day.  
Life moves forward with or without you.

---

## 🧠 Design Goals

- **Tiny but memorable**  
  Instead of a big system-heavy game, this project focuses on *one* strong scene, polished as much as possible.

- **Character through repetition**  
  The old man’s catchphrase – `Not my problem.` – is repeated with different timing, delivery and context, until it changes meaning.

- **Feeling over mechanics**  
  This is more of a **short film you can poke** than a traditional game.  
  The goal is to leave a mood in the player, not a high score.

- **Progression as decay**  
  The world doesn’t level up; it **wears out**.  
  Each “day” is slightly more broken, cruel, or absurd than the last.

---

## 📖 Event & Progression (High Level)

The game progresses through **phases**, but each run still feels random:

1. **Ordinary Days**  
   - Cars passing, tumbleweed, distant gunshots, animals crossing the road.  
   - The neighbor is alive; sometimes you get a little **cheers** moment together.

2. **Strange Days**  
   - Odd shadows, wrong-way cars, small meteors, radio interference.  
   - The world feels slightly “off”, but still deniable.

3. **Bad Days**  
   - Heavier accidents, unnaturally bright lights, time feeling slower.  
   - The radio starts saying things that feel a bit too personal.

4. **Loss**  
   - One day, your neighbor doesn’t move. People gather, and someone cries.  
   - The next day, a bulldozer arrives and tears down his house.  
   - Life goes on. You’re still on your porch.

5. **The Last Problem**  
   - Rare final events (abduction, collapse, death, etc.)  
   - For once, the old man doesn’t get to say “Not my problem.”

*(Implementation details are intentionally vague here to avoid spoilers on the main page.)*

---

## 🛠 Tech & Tools

*(Adjust this section to match your actual stack.)*

- **Engine:** Unity (URP/HDRP)  
- **Language:** C#  
- **Target Platform:** PC (Windows)  
- **Version Control:** Git + GitHub  
- **Art:** Simple 3D / stylized low-poly + baked lighting  
- **Audio:** AI-assisted western soundtrack + SFX (radio, wind, footsteps, vehicles)

---

## 🚀 How to Run

### Option 1 – Download Build (Recommended)

1. Go to the **Releases** section on GitHub or the **itch.io** page.  
2. Download the latest version for your platform.  
3. Extract the archive.  
4. Run:

   - `NotMyProblem.exe` (Windows)

