/* =========================
   BRIGHT DEV 2.0
   MAIN STYLES
========================= */

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html {
    scroll-behavior: smooth;
}

body {
    font-family: Arial, Helvetica, sans-serif;
    background: #07111f;
    color: #ffffff;
    line-height: 1.6;
}

a {
    text-decoration: none;
    color: inherit;
}

button {
    font-family: inherit;
}


/* =========================
   NAVBAR
========================= */

.navbar {
    width: 100%;
    padding: 20px 7%;
    display: flex;
    justify-content: space-between;
    align-items: center;
    position: sticky;
    top: 0;
    z-index: 1000;
    background: rgba(7, 17, 31, 0.9);
    backdrop-filter: blur(15px);
    border-bottom: 1px solid rgba(255,255,255,0.08);
}

.logo {
    display: flex;
    align-items: center;
    gap: 10px;
    font-size: 22px;
    font-weight: 800;
}

.logo-icon {
    width: 38px;
    height: 38px;
    display: flex;
    justify-content: center;
    align-items: center;
    border-radius: 10px;
    background: #3b82f6;
    font-weight: 900;
}

.logo-highlight {
    color: #3b82f6;
}

.navbar nav {
    display: flex;
    gap: 30px;
}

.navbar nav a {
    color: #cbd5e1;
    transition: 0.3s;
}

.navbar nav a:hover {
    color: #3b82f6;
}

.menu-btn {
    display: none;
    background: none;
    border: none;
    color: white;
    font-size: 25px;
}


/* =========================
   HERO
========================= */

.hero {
    min-height: 90vh;
    padding: 100px 7%;
    display: flex;
    align-items: center;
    justify-content: space-between;
    gap: 60px;
    background:
        radial-gradient(circle at 20% 20%, rgba(59,130,246,0.18), transparent 35%),
        radial-gradient(circle at 80% 60%, rgba(99,102,241,0.12), transparent 35%);
}

.hero-content {
    max-width: 650px;
}

.badge {
    display: inline-block;
    padding: 8px 15px;
    border: 1px solid rgba(59,130,246,0.4);
    background: rgba(59,130,246,0.08);
    color: #60a5fa;
    border-radius: 30px;
    margin-bottom: 25px;
    font-size: 14px;
}

.hero h1 {
    font-size: clamp(45px, 6vw, 78px);
    line-height: 1.05;
    margin-bottom: 25px;
}

.hero h1 span,
.section-heading h2 span,
.about-text h2 span,
.suggest-section h2 span,
.about-card h3 span {
    color: #3b82f6;
}

.hero-content > p {
    color: #a8b5c7;
    font-size: 18px;
    max-width: 570px;
    margin-bottom: 35px;
}

.hero-buttons {
    display: flex;
    gap: 15px;
    flex-wrap: wrap;
}

.primary-btn,
.secondary-btn {
    display: inline-block;
    padding: 14px 24px;
    border-radius: 10px;
    border: none;
    cursor: pointer;
    font-weight: 700;
    transition: 0.3s;
}

.primary-btn {
    background: #3b82f6;
    color: white;
}

.primary-btn:hover {
    transform: translateY(-3px);
    box-shadow: 0 10px 30px rgba(59,130,246,0.25);
}

.secondary-btn {
    border: 1px solid rgba(255,255,255,0.15);
    color: white;
    background: rgba(255,255,255,0.04);
}

.secondary-btn:hover {
    background: rgba(255,255,255,0.08);
}


/* =========================
   HERO CARD
========================= */

.hero-card {
    position: relative;
    width: 450px;
}

.dashboard-card {
    padding: 30px;
    background: rgba(15,28,48,0.9);
    border: 1px solid rgba(255,255,255,0.1);
    border-radius: 25px;
    box-shadow: 0 30px 80px rgba(0,0,0,0.3);
}

.dashboard-top {
    display: flex;
    justify-content: space-between;
    margin-bottom: 35px;
    color: #cbd5e1;
}

.online {
    color: #4ade80;
    font-size: 13px;
}

.dashboard-card h3 {
    font-size: 25px;
    margin-bottom: 25px;
}

.mini-tools {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 15px;
}

.mini-tool {
    padding: 20px;
    background: rgba(255,255,255,0.04);
    border-radius: 15px;
    transition: 0.3s;
}

.mini-tool:hover {
    transform: translateY(-4px);
    background: rgba(59,130,246,0.1);
}

.mini-tool span {
    font-size: 25px;
}

.mini-tool p {
    color: #b9c5d4;
    margin-top: 8px;
}

.floating-icon {
    position: absolute;
    padding: 15px;
    border-radius: 15px;
    background: #0d1c31;
    border: 1px solid rgba(255,255,255,0.1);
    font-size: 24px;
    animation: float 3s infinite ease-in-out;
}

.icon-one {
    top: -25px;
    right: -20px;
}

.icon-two {
    bottom: 30px;
    left: -35px;
    animation-delay: 1s;
}

.icon-three {
    top: 45%;
    right: -40px;
    animation-delay: 2s;
}

@keyframes float {
    0%, 100% {
        transform: translateY(0);
    }

    50% {
        transform: translateY(-12px);
    }
}


/* =========================
   GENERAL SECTIONS
========================= */

.tools-section,
.about-section,
.contact-section {
    padding: 110px 7%;
}

.section-heading {
    text-align: center;
    max-width: 700px;
    margin: auto;
}

.small-title {
    color: #3b82f6;
    font-size: 13px;
    font-weight: 800;
    letter-spacing: 2px;
}

.section-heading h2,
.about-text h2,
.suggest-section h2 {
    font-size: clamp(35px, 5vw, 55px);
    line-height: 1.1;
    margin: 15px 0;
}

.section-heading p,
.about-text > p {
    color: #9aa9bc;
}


/* =========================
   TOOLS
========================= */

.tools-grid {
    max-width: 1200px;
    margin: 60px auto 0;
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 20px;
}

.tool-card {
    padding: 30px;
    background: #0c1a2d;
    border: 1px solid rgba(255,255,255,0.07);
    border-radius: 20px;
    transition: 0.3s;
}

.tool-card:hover {
    transform: translateY(-8px);
    border-color: rgba(59,130,246,0.4);
}

.tool-icon {
    font-size: 35px;
    margin-bottom: 20px;
}

.tool-card h3 {
    font-size: 22px;
    margin-bottom: 10px;
}

.tool-card p {
    color: #94a3b8;
    margin-bottom: 25px;
}

.coming-btn {
    padding: 9px 14px;
    border: none;
    border-radius: 7px;
    background: rgba(59,130,246,0.1);
    color: #60a5fa;
}


/* =========================
   ABOUT
========================= */

.about-section {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 70px;
    align-items: center;
    background: #091625;
}

.about-points {
    margin-top: 35px;
    display: grid;
    gap: 20px;
}

.about-points strong {
    font-size: 18px;
}

.about-points p {
    color: #8998aa;
}

.about-card {
    padding: 45px;
    background: #0c1a2d;
    border-radius: 25px;
    border: 1px solid rgba(255,255,255,0.08);
}

.quote-icon {
    font-size: 60px;
    color: #3b82f6;
}

.about-card h3 {
    font-size: 35px;
    line-height: 1.2;
    margin-bottom: 15px;
}

.about-card p {
    color: #94a3b8;
}

.progress {
    margin-top: 35px;
}

.progress-label {
    display: flex;
    justify-content: space-between;
    margin-bottom: 10px;
}

.progress-bar {
    height: 8px;
    background: #17253a;
    border-radius: 10px;
    overflow: hidden;
}

.progress-bar div {
    width: 75%;
    height: 100%;
    background: #3b82f6;
}


/* =========================
   SUGGEST SECTION
========================= */

.suggest-section {
    margin: 100px 7%;
    padding: 60px;
    border-radius: 25px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    gap: 30px;
    background:
        radial-gradient(circle at 10% 50%, rgba(59,130,246,0.25), transparent 35%),
        #0c1a2d;
    border: 1px solid rgba(255,255,255,0.08);
}

.suggest-section h2 {
    max-width: 600px;
}

.suggest-section p {
    color: #94a3b8;
}


/* =========================
   CONTACT
========================= */

.contact-cards {
    max-width: 1000px;
    margin: 50px auto 0;
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 20px;
}

.contact-card {
    padding: 30px;
    background: #0c1a2d;
    border: 1px solid rgba(255,255,255,0.07);
    border-radius: 18px;
    color: white;
    cursor: pointer;
    text-align: center;
    transition: 0.3s;
}

.contact-card:hover {
    transform: translateY(-5px);
    border-color: rgba(59,130,246,0.4);
}

.contact-icon {
    font-size: 30px;
    margin-bottom: 15px;
}

.contact-card p {
    color: #94a3b8;
}


/* =========================
   FOOTER
========================= */

footer {
    padding: 60px 7%;
    text-align: center;
    background: #050c15;
    border-top: 1px solid rgba(255,255,255,0.06);
}

.footer-logo {
    font-size: 25px;
    font-weight: 800;
}

.footer-logo span {
    color: #3b82f6;
}

footer > p {
    color: #7f8da0;
    margin: 10px 0;
}

.footer-links {
    display: flex;
    justify-content: center;
    gap: 25px;
    margin: 25px 0;
}

.footer-links a:hover {
    color: #3b82f6;
}

.copyright {
    font-size: 13px;
}


/* =========================
   MODAL
========================= */

.modal {
    position: fixed;
    inset: 0;
    display: none;
    justify-content: center;
    align-items: center;
    padding: 20px;
    background: rgba(0,0,0,0.75);
    z-index: 2000;
}

.modal.active {
    display: flex;
}

.modal-box {
    position: relative;
    width: 100%;
    max-width: 500px;
    padding: 40px;
    border-radius: 20px;
    background: #0c1a2d;
    border: 1px solid rgba(255,255,255,0.1);
}

.close-btn {
    position: absolute;
    right: 20px;
    top: 15px;
    border: none;
    background: none;
    color: white;
    font-size: 30px;
    cursor: pointer;
}

.modal-icon {
    font-size: 40px;
}

.modal-box h2 {
    font-size: 30px;
    margin: 10px 0;
}

.modal-box p {
    color: #94a3b8;
    margin-bottom: 25px;
}

.modal-box input,
.modal-box textarea {
    width: 100%;
    margin-bottom: 15px;
    padding: 15px;
    border: 1px solid rgba(255,255,255,0.1);
    border-radius: 10px;
    outline: none;
    background: #07111f;
    color: white;
    font-family: inherit;
}

.modal-box textarea {
    min-height: 120px;
    resize: vertical;
}


/* =========================
   MOBILE
========================= */

@media (max-width: 900px) {

    .navbar nav {
        display: none;
    }

    .menu-btn {
        display: block;
    }

    .hero {
        flex-direction: column;
        text-align: center;
        padding-top: 80px;
    }

    .hero-content > p {
        margin-left: auto;
        margin-right: auto;
    }

    .hero-buttons {
        justify-content: center;
    }

    .hero-card {
        width: 100%;
        max-width: 450px;
    }

    .tools-grid {
        grid-template-columns: 1fr 1fr;
    }

    .about-section {
        grid-template-columns: 1fr;
    }

    .suggest-section {
        flex-direction: column;
        text-align: center;
    }

    .contact-cards {
        grid-template-columns: 1fr;
    }
}


@media (max-width: 600px) {

    .navbar {
        padding: 15px 5%;
    }

    .hero {
        padding: 70px 5%;
    }

    .hero h1 {
        font-size: 45px;
    }

    .tools-section,
    .about-section,
    .contact-section {
        padding: 80px 5%;
    }

    .tools-grid {
        grid-template-columns: 1fr;
    }

    .suggest-section {
        margin: 60px 5%;
        padding: 40px 25px;
    }

    .about-card {
        padding: 30px;
    }

    .floating-icon {
        display: none;
    }

    .mini-tools {
        grid-template-columns: 1fr;
    }

    .footer-links {
        flex-wrap: wrap;
    }
}
