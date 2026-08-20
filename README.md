# 🌊 Interferențe ECO

Un joc puzzle-educațional dezvoltat în **C# (Windows Forms)** în care jucătorul trebuie să ghideze un robot pentru a curăța oceanul de deșeuri (Sticlă, Plastic, Hârtie), evitând în același timp vietățile marine.

>  Acest proiect folosește o interfață bazată pe grid și mecanici de redirecționare a mișcării pentru a rezolva nivelurile.

---

![Meniu Principal](./Resources/preview.png)

---

## 🎮 Cum se joacă

Scopul jocului este să aduni toate deșeurile de pe hartă folosind robotul, fără să lovești vietățile marine (meduzele).

**Mecanici principale:**
1. **Încărcarea Hărții:** Jocul începe prin încărcarea unui fișier `.txt` care conține nivelul.
2. **Deflectoare (Săgeți de direcție):** Robotul se mișcă în linie dreaptă. Jucătorul trebuie să plaseze strategic *deflectoare* pe hartă și să le rotească pentru a schimba direcția robotului (Sus, Jos, Stânga, Dreapta).
3. **Condiții de Victorie:** Jocul este câștigat atunci când contorul pentru Sticlă, Plastic și Hârtie ajunge la totalul de pe hartă.
4. **Condiții de Înfrângere:** Jocul se termină dacă robotul se lovește de o vietate marină (`Meduza`).

---

## 🛠️ Instalare și Rulare (Build)

Deoarece jocul este construit folosind **Windows Forms**, ai nevoie de un mediu de dezvoltare compatibil cu ecosistemul .NET pe Windows.

### Cerințe:
* Sistem de operare: **Windows**
* [Visual Studio](https://visualstudio.microsoft.com/) (recomandat 2019, 2022) cu workload-ul `.NET desktop development` instalat.