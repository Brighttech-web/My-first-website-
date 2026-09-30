
    * {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: Arial, sans-serif;
}

body {
    background: #f7f9fc;
    color: #111827;
    line-height: 1.6;
}

header {
    background: #07111f;
    color: white;
    padding: 18px 7%;
    display: flex;
    justify-content: space-between;
    align-items: center;
    position: sticky;
    top: 0;
    z-index: 1000;
}

.logo {
    font-size: 25px;
    font-weight: bold;
}

.logo span {
    color: #3b82f6;
}

nav a {
    color: white;
    text-decoration: none;
    margin-left: 25px;
    font-weight: 500;
}

nav a:hover {
    color: #3b82f6;
}

.hero {
    min-height: 80vh;
    display: flex;
    align-items: center;
    justify-content: center;
    text-align: center;
    padding: 70px 20px;
    background: linear-gradient(135deg, #07111f, #102a43);
    color: white;
}

.hero-content {
    max-width: 850px;
}

.hero h1 {
    font-size: 60px;
    line-height: 1.1;
    margin-bottom: 20px;
}

.hero h1 span {
    color: #3b82f6;
}

.hero p {
    font-size: 19px;
    color: #d1d5db;
    max-width: 650px;
    margin: 0 auto 30px;
}

.buttons {
    display: flex;
    justify-content: center;
    gap: 15px;
    flex-wrap: wrap;
}

.btn {
    display: inline-block;
    padding: 14px 24px;
    border-radius: 8px;
    text-decoration: none;
    font-weight: bold;
    transition: 0.3s;
}

.primary {
    background: #2563eb;
    color: white;
}

.primary:hover {
    background: #1d4ed8;
    transform: translateY(-2px);
}

.secondary {
    border: 1px solid #64748b;
    color: white;
}

.secondary:hover {
    background: white;
    color: #07111f;
}

section {
    padding: 80px 7%;
}

.section-title {
    text-align: center;
    margin-bottom: 45px;
}

.section-title h2 {
    font-size: 35px;
    margin-bottom: 10px;
}

.section-title p {
    color: #6b7280;
}

.tools-grid {
    max-width: 1100px;
    margin: auto;
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 25px;
}

.tool-card {
    background: white;
    padding: 30px;
    border-radius: 16px;
    border: 1px solid #e5e7eb;
    transition: 0.3s;
}

.tool-card:hover {
    transform: translateY(-7px);
    box-shadow: 0 15px 35px rgba(0,0,0,0.08);
}

.tool-icon {
    font-size: 35px;
    margin-bottom: 15px;
}

.tool-card h3 {
    margin-bottom: 10px;
}

.tool-card p {
    color: #6b7280;
}

.about {
    background: white;
    text-align: center;
}

.about-content {
    max-width: 750px;
    margin: auto;
}

.about-content p {
    color: #6b7280;
    margin-top: 15px;
}

.cta {
    text-align: center;
    background: #07111f;
    color: white;
}

.cta p {
    color: #cbd5e1;
    margin: 15px auto 25px;
}

footer {
    background: #030712;
    color: #9ca3af;
    text-align: center;
    padding: 25px;
}

@media (max-width: 800px) {

    header {
        flex-direction: column;
        gap: 15px;
    }

    nav a {
        margin: 0 8px;
    }

    .hero h1 {
        font-size: 42px;
    }

    .tools-grid {
        grid-template-columns: 1fr;
    }

    section {
        padding: 60px 20px;
    }
}
