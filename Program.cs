<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>My Website</title>

    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: Arial, Helvetica, sans-serif;
        }

        html {
            scroll-behavior: smooth;
        }

        body {
            background: #f5f7fb;
            color: #1e293b;
            line-height: 1.6;
        }

        /* =========================
           NAVIGATION
        ========================= */

        nav {
            position: sticky;
            top: 0;
            z-index: 1000;

            display: flex;
            justify-content: space-between;
            align-items: center;

            padding: 18px 8%;

            background: #0f172a;
            box-shadow: 0 3px 15px rgba(0, 0, 0, 0.15);
        }

        nav .logo {
            color: white;
            font-size: 24px;
            font-weight: bold;
            text-decoration: none;
        }

        nav ul {
            display: flex;
            align-items: center;
            gap: 30px;
            list-style: none;
        }

        nav ul li a {
            color: #e2e8f0;
            text-decoration: none;
            font-size: 15px;
            transition: 0.3s;
        }

        nav ul li a:hover {
            color: #38bdf8;
        }

        .nav-login {
            border: 1px solid #38bdf8;
            padding: 8px 18px;
            border-radius: 6px;
        }

        .nav-register {
            background: #2563eb;
            padding: 9px 18px;
            border-radius: 6px;
            color: white !important;
        }

        .nav-register:hover {
            background: #1d4ed8;
        }


        /* =========================
           LANDING / HERO
        ========================= */

        .hero {
            min-height: 90vh;

            display: flex;
            align-items: center;

            padding: 80px 8%;

            background:
                linear-gradient(
                    135deg,
                    rgba(15, 23, 42, 0.98),
                    rgba(30, 64, 175, 0.9)
                );

            color: white;
        }

        .hero-content {
            max-width: 750px;
        }

        .hero-tag {
            display: inline-block;

            padding: 7px 15px;
            margin-bottom: 20px;

            background: rgba(56, 189, 248, 0.15);
            border: 1px solid rgba(56, 189, 248, 0.4);

            border-radius: 30px;

            color: #7dd3fc;
            font-size: 14px;
            font-weight: bold;
        }

        .hero h1 {
            font-size: 60px;
            line-height: 1.1;
            margin-bottom: 25px;
        }

        .hero h1 span {
            color: #38bdf8;
        }

        .hero p {
            max-width: 650px;

            color: #cbd5e1;

            font-size: 19px;
            margin-bottom: 35px;
        }

        .hero-buttons {
            display: flex;
            gap: 15px;
        }

        .btn {
            display: inline-block;

            padding: 13px 25px;

            border-radius: 7px;

            text-decoration: none;
            font-weight: bold;

            transition: 0.3s;
        }

        .btn-primary {
            background: #2563eb;
            color: white;
        }

        .btn-primary:hover {
            background: #1d4ed8;
            transform: translateY(-2px);
        }

        .btn-outline {
            border: 1px solid #94a3b8;
            color: white;
        }

        .btn-outline:hover {
            background: white;
            color: #0f172a;
        }


        /* =========================
           GENERAL SECTIONS
        ========================= */

        section {
            scroll-margin-top: 80px;
        }

        .section {
            padding: 90px 8%;
        }

        .section-title {
            text-align: center;
            margin-bottom: 55px;
        }

        .section-title span {
            color: #2563eb;
            font-size: 14px;
            font-weight: bold;
            text-transform: uppercase;
            letter-spacing: 1px;
        }

        .section-title h2 {
            font-size: 38px;
            margin-top: 8px;
            color: #0f172a;
        }

        .section-title p {
            max-width: 650px;
            margin: 12px auto 0;
            color: #64748b;
        }


        /* =========================
           ABOUT
        ========================= */

        .about {
            background: white;
        }

        .about-container {
            max-width: 1100px;
            margin: auto;

            display: grid;
            grid-template-columns: 1fr 1fr;

            gap: 60px;
            align-items: center;
        }

        .about-text span {
            color: #2563eb;
            font-size: 14px;
            font-weight: bold;
        }

        .about-text h2 {
            font-size: 38px;
            color: #0f172a;
            margin: 10px 0 20px;
        }

        .about-text p {
            color: #64748b;
            margin-bottom: 18px;
        }

        .about-box {
            background: #eff6ff;
            border-left: 4px solid #2563eb;

            padding: 20px;

            margin-top: 25px;
        }

        .about-box strong {
            color: #0f172a;
        }


        /* =========================
           SERVICES
        ========================= */

        .services {
            background: #f8fafc;
        }

        .cards {
            max-width: 1100px;
            margin: auto;

            display: grid;
            grid-template-columns: repeat(3, 1fr);

            gap: 25px;
        }

        .card {
            background: white;

            padding: 35px 30px;

            border-radius: 12px;

            border: 1px solid #e2e8f0;

            box-shadow: 0 10px 25px rgba(15, 23, 42, 0.05);

            transition: 0.3s;
        }

        .card:hover {
            transform: translateY(-8px);

            box-shadow:
                0 15px 35px rgba(15, 23, 42, 0.12);
        }

        .card-icon {
            width: 55px;
            height: 55px;

            display: flex;
            align-items: center;
            justify-content: center;

            background: #dbeafe;
            color: #2563eb;

            border-radius: 10px;

            font-size: 24px;

            margin-bottom: 22px;
        }

        .card h3 {
            color: #0f172a;
            font-size: 21px;
            margin-bottom: 12px;
        }

        .card p {
            color: #64748b;
        }


        /* =========================
           CONTACT
        ========================= */

        .contact {
            background: white;
        }

        .contact-container {
            max-width: 1100px;
            margin: auto;

            display: grid;
            grid-template-columns: 1fr 1.3fr;

            gap: 60px;
        }

        .contact-info h2 {
            font-size: 36px;
            color: #0f172a;
            margin-bottom: 15px;
        }

        .contact-info > p {
            color: #64748b;
            margin-bottom: 30px;
        }

        .contact-item {
            display: flex;
            gap: 15px;
            margin-bottom: 20px;
        }

        .contact-icon {
            width: 42px;
            height: 42px;

            display: flex;
            justify-content: center;
            align-items: center;

            background: #dbeafe;
            color: #2563eb;

            border-radius: 8px;
        }

        .contact-item strong {
            display: block;
            color: #0f172a;
        }

        .contact-item p {
            color: #64748b;
        }

        .contact-form {
            background: #f8fafc;

            padding: 35px;

            border-radius: 12px;
            border: 1px solid #e2e8f0;
        }

        .form-row {
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 15px;
        }

        .form-group {
            margin-bottom: 18px;
        }

        .form-group label {
            display: block;
            margin-bottom: 7px;

            color: #334155;
            font-size: 14px;
            font-weight: bold;
        }

        input,
        textarea,
        select {
            width: 100%;

            padding: 13px 14px;

            border: 1px solid #cbd5e1;
            border-radius: 7px;

            background: white;

            font-size: 15px;

            outline: none;

            transition: 0.3s;
        }

        input:focus,
        textarea:focus,
        select:focus {
            border-color: #2563eb;

            box-shadow:
                0 0 0 3px rgba(37, 99, 235, 0.1);
        }

        textarea {
            resize: vertical;
            min-height: 130px;
        }

        .submit-btn {
            width: 100%;

            padding: 13px;

            border: none;
            border-radius: 7px;

            background: #2563eb;
            color: white;

            font-size: 15px;
            font-weight: bold;

            cursor: pointer;

            transition: 0.3s;
        }

        .submit-btn:hover {
            background: #1d4ed8;
        }


        /* =========================
           LOGIN & REGISTER
        ========================= */

        .account-section {
            background: #f8fafc;
        }

        .account-container {
            max-width: 1050px;
            margin: auto;

            display: grid;
            grid-template-columns: 1fr 1fr;

            gap: 30px;
        }

        .account-card {
            background: white;

            padding: 40px;

            border-radius: 12px;

            border: 1px solid #e2e8f0;

            box-shadow:
                0 10px 30px rgba(15, 23, 42, 0.06);
        }

        .account-header {
            text-align: center;
            margin-bottom: 30px;
        }

        .account-icon {
            width: 60px;
            height: 60px;

            display: flex;
            align-items: center;
            justify-content: center;

            margin: 0 auto 15px;

            background: #dbeafe;
            color: #2563eb;

            border-radius: 50%;

            font-size: 25px;
        }

        .account-header h2 {
            color: #0f172a;
            margin-bottom: 5px;
        }

        .account-header p {
            color: #64748b;
            font-size: 14px;
        }

        .account-card .form-group {
            margin-bottom: 17px;
        }

        .account-card .submit-btn {
            margin-top: 5px;
        }

        .account-link {
            text-align: center;
            margin-top: 20px;

            color: #64748b;
            font-size: 14px;
        }

        .account-link a {
            color: #2563eb;
            font-weight: bold;
            text-decoration: none;
        }

        .account-link a:hover {
            text-decoration: underline;
        }


        /* =========================
           FOOTER
        ========================= */

        footer {
            background: #0f172a;
            color: #94a3b8;

            text-align: center;

            padding: 30px 20px;
        }

        footer .footer-logo {
            color: white;
            font-size: 22px;
            font-weight: bold;
            margin-bottom: 8px;
        }

        footer p {
            font-size: 14px;
        }

        footer .social {
            margin-top: 15px;
        }

        footer .social a {
            color: #cbd5e1;
            text-decoration: none;
            margin: 0 8px;
        }

        footer .social a:hover {
            color: #38bdf8;
        }


        /* =========================
           MOBILE RESPONSIVE
        ========================= */

        @media (max-width: 850px) {

            nav {
                flex-direction: column;
                gap: 15px;
            }

            nav ul {
                flex-wrap: wrap;
                justify-content: center;
                gap: 15px;
            }

            .hero h1 {
                font-size: 45px;
            }

            .about-container,
            .contact-container,
            .account-container {
                grid-template-columns: 1fr;
            }

            .cards {
                grid-template-columns: 1fr;
            }
        }

        @media (max-width: 600px) {

            .section {
                padding: 65px 6%;
            }

            .hero {
                min-height: 80vh;
                padding: 60px 6%;
            }

            .hero h1 {
                font-size: 38px;
            }

            .hero p {
                font-size: 16px;
            }

            .hero-buttons {
                flex-direction: column;
            }

            .btn {
                text-align: center;
            }

            .section-title h2 {
                font-size: 30px;
            }

            .about-text h2,
            .contact-info h2 {
                font-size: 30px;
            }

            .account-card {
                padding: 25px;
            }

            .form-row {
                grid-template-columns: 1fr;
            }
        }
    </style>
</head>

<body>


    <!-- =========================
         NAVIGATION
    ========================= -->

    <nav>

        <a href="#landing" class="logo">
            My Website
        </a>

        <ul>
            <li><a href="#landing">Home</a></li>
            <li><a href="#about">About</a></li>
            <li><a href="#services">Services</a></li>
            <li><a href="#contact">Contact</a></li>
            <li>
                <a href="#login" class="nav-login">
                    Login
                </a>
            </li>
            <li>
                <a href="#register" class="nav-register">
                    Register
                </a>
            </li>
        </ul>

    </nav>


    <!-- =========================
         LANDING / HERO
    ========================= -->

    <section class="hero" id="landing">

        <div class="hero-content">

            <span class="hero-tag">
                WELCOME TO OUR WEBSITE
            </span>

            <h1>
                Build Something
                <span>Amazing.</span>
            </h1>

            <p>
                We create modern, reliable, and user-friendly
                digital solutions designed to help you succeed
                in today's digital world.
            </p>

            <div class="hero-buttons">

                <a href="#services" class="btn btn-primary">
                    Explore Services
                </a>

                <a href="#about" class="btn btn-outline">
                    Learn More
                </a>

            </div>

        </div>

    </section>


    <!-- =========================
         ABOUT
    ========================= -->

    <section class="section about" id="about">

        <div class="about-container">

            <div class="about-text">

                <span>ABOUT US</span>

                <h2>
                    We Build Solutions
                    That Make a Difference
                </h2>

                <p>
                    Welcome to our website. We are focused on
                    creating high-quality digital experiences
                    that are simple, effective, and easy to use.
                </p>

                <p>
                    Our goal is to combine modern technology
                    with thoughtful design to provide solutions
                    that meet the needs of our users.
                </p>

                <div class="about-box">

                    <strong>
                        Our Mission
                    </strong>

                    <p>
                        To create reliable and innovative
                        digital solutions that help people
                        and businesses grow.
                    </p>

                </div>

            </div>


            <div>

                <div class="card">

                    <div class="card-icon">
                        ★
                    </div>

                    <h3>
                        Quality First
                    </h3>

                    <p>
                        We believe that every project should
                        be designed with quality, reliability,
                        and user experience in mind.
                    </p>

                </div>

                <br>

                <div class="card">

                    <div class="card-icon">
                        ✓
                    </div>

                    <h3>
                        User Focused
                    </h3>

                    <p>
                        We create solutions that are simple,
                        accessible, and easy for everyone to use.
                    </p>

                </div>

            </div>

        </div>

    </section>


    <!-- =========================
         SERVICES
    ========================= -->

    <section class="section services" id="services">

        <div class="section-title">

            <span>OUR SERVICES</span>

            <h2>
                What We Offer
            </h2>

            <p>
                Explore our range of services designed to
                help you create and improve your digital presence.
            </p>

        </div>


        <div class="cards">

            <div class="card">

                <div class="card-icon">
                    ◈
                </div>

                <h3>
                    Web Design
                </h3>

                <p>
                    We create clean, modern, and attractive
                    website designs that work across different
                    devices and screen sizes.
                </p>

            </div>


            <div class="card">

                <div class="card-icon">
                    &lt;/&gt;
                </div>

                <h3>
                    Development
                </h3>

                <p>
                    We build functional and responsive websites
                    using modern web technologies and development
                    practices.
                </p>

            </div>


            <div class="card">

                <div class="card-icon">
                    ?
                </div>

                <h3>
                    Support
                </h3>

                <p>
                    We provide ongoing assistance to help maintain,
                    improve, and update your website.
                </p>

            </div>

        </div>

    </section>


    <!-- =========================
         CONTACT
    ========================= -->

    <section class="section contact" id="contact">

        <div class="contact-container">

            <div class="contact-info">

                <span style="color:#2563eb;font-weight:bold;">
                    CONTACT US
                </span>

                <h2>
                    Get In Touch
                </h2>

                <p>
                    Have a question or want to work with us?
                    Send us a message and we will get back
                    to you as soon as possible.
                </p>


                <div class="contact-item">

                    <div class="contact-icon">
                        @
                    </div>

                    <div>
                        <strong>Email</strong>
                        <p>example@email.com</p>
                    </div>

                </div>


                <div class="contact-item">

                    <div class="contact-icon">
                        ☎
                    </div>

                    <div>
                        <strong>Phone</strong>
                        <p>+63 900 000 0000</p>
                    </div>

                </div>


                <div class="contact-item">

                    <div class="contact-icon">
                        ●
                    </div>

                    <div>
                        <strong>Location</strong>
                        <p>Philippines</p>
                    </div>

                </div>

            </div>


            <div class="contact-form">

                <form>

                    <div class="form-row">

                        <div class="form-group">

                            <label for="contact-name">
                                Name
                            </label>

                            <input
                                type="text"
                                id="contact-name"
                                placeholder="Your name"
                                required
                            >

                        </div>


                        <div class="form-group">

                            <label for="contact-email">
                                Email
                            </label>

                            <input
                                type="email"
                                id="contact-email"
                                placeholder="Your email"
                                required
                            >

                        </div>

                    </div>


                    <div class="form-group">

                        <label for="subject">
                            Subject
                        </label>

                        <input
                            type="text"
                            id="subject"
                            placeholder="What is this about?"
                            required
                        >

                    </div>


                    <div class="form-group">

                        <label for="message">
                            Message
                        </label>

                        <textarea
                            id="message"
                            placeholder="Write your message here..."
                            required
                        ></textarea>

                    </div>


                    <button
                        type="submit"
                        class="submit-btn"
                    >
                        Send Message
                    </button>

                </form>

            </div>

        </div>

    </section>


    <!-- =========================
         LOGIN & REGISTRATION
    ========================= -->

    <section
        class="section account-section"
        id="login"
    >

        <div class="section-title">

            <span>ACCOUNT</span>

            <h2>
                Welcome Back
            </h2>

            <p>
                Login to access your account.
            </p>

        </div>


        <div class="account-container">


            <!-- LOGIN -->

            <div class="account-card">

                <div class="account-header">

                    <div class="account-icon">
                        ●
                    </div>

                    <h2>
                        Login
                    </h2>

                    <p>
                        Enter your account details below.
                    </p>

                </div>


                <form>

                    <div class="form-group">

                        <label for="login-username">
                            Username
                        </label>

                        <input
                            type="text"
                            id="login-username"
                            placeholder="Enter your username"
                            required
                        >

                    </div>


                    <div class="form-group">

                        <label for="login-password">
                            Password
                        </label>

                        <input
                            type="password"
                            id="login-password"
                            placeholder="Enter your password"
                            required
                        >

                    </div>


                    <button
                        type="submit"
                        class="submit-btn"
                    >
                        Login
                    </button>

                </form>


                <div class="account-link">

                    Don't have an account?

                    <a href="#register">
                        Register here
                    </a>

                </div>

            </div>


            <!-- REGISTER -->

            <div class="account-card" id="register">

                <div class="account-header">

                    <div class="account-icon">
                        +
                    </div>

                    <h2>
                        Create Account
                    </h2>

                    <p>
                        Register to create your account.
                    </p>

                </div>


                <form>

                    <div class="form-group">

                        <label for="fullname">
                            Full Name
                        </label>

                        <input
                            type="text"
                            id="fullname"
                            placeholder="Enter your full name"
                            required
                        >

                    </div>


                    <div class="form-group">

                        <label for="register-email">
                            Email
                        </label>

                        <input
                            type="email"
                            id="register-email"
                            placeholder="Enter your email"
                            required
                        >

                    </div>


                    <div class="form-group">

                        <label for="register-username">
                            Username
                        </label>

                        <input
                            type="text"
                            id="register-username"
                            placeholder="Choose a username"
                            required
                        >

                    </div>


                    <div class="form-group">

                        <label for="register-password">
                            Password
                        </label>

                        <input
                            type="password"
                            id="register-password"
                            placeholder="Create a password"
                            required
                        >

                    </div>


                    <div class="form-group">

                        <label for="confirm-password">
                            Confirm Password
                        </label>

                        <input
                            type="password"
                            id="confirm-password"
                            placeholder="Confirm your password"
                            required
                        >

                    </div>


                    <button
                        type="submit"
                        class="submit-btn"
                    >
                        Create Account
                    </button>

                </form>


                <div class="account-link">

                    Already have an account?

                    <a href="#login">
                        Login here
                    </a>

                </div>

            </div>

        </div>

    </section>


    <!-- =========================
         FOOTER
    ========================= -->

    <footer>

        <div class="footer-logo">
            My Website
        </div>

        <p>
            Building modern and reliable digital experiences.
        </p>

        <div class="social">

            <a href="#">Facebook</a>
            <a href="#">Twitter</a>
            <a href="#">Instagram</a>
            <a href="#">LinkedIn</a>

        </div>

        <br>

        <p>
            &copy; 2026 My Website.
            All Rights Reserved.
        </p>

    </footer>

</body>
</html>
