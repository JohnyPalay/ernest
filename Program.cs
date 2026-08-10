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
            font-family: Arial, sans-serif;
        }

        body {
            background-color: #f4f4f4;
            color: #333;
        }

        /* Navigation */
        nav {
            background-color: #222;
            padding: 20px;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        nav h2 {
            color: white;
        }

        nav ul {
            list-style: none;
            display: flex;
            gap: 25px;
        }

        nav ul li a {
            color: white;
            text-decoration: none;
            font-size: 16px;
        }

        nav ul li a:hover {
            color: #00aaff;
        }

        /* Hero Section */
        .hero {
            height: 500px;
            display: flex;
            justify-content: center;
            align-items: center;
            text-align: center;
            background: linear-gradient(135deg, #007bff, #00c6ff);
            color: white;
        }

        .hero h1 {
            font-size: 50px;
            margin-bottom: 15px;
        }

        .hero p {
            font-size: 20px;
            margin-bottom: 25px;
        }

        .btn {
            display: inline-block;
            background-color: white;
            color: #007bff;
            padding: 12px 25px;
            border-radius: 5px;
            text-decoration: none;
            font-weight: bold;
        }

        .btn:hover {
            background-color: #eee;
        }

        /* About Section */
        .about {
            padding: 60px 20px;
            text-align: center;
            background-color: white;
        }

        .about h2 {
            font-size: 35px;
            margin-bottom: 20px;
        }

        .about p {
            max-width: 700px;
            margin: auto;
            line-height: 1.7;
        }

        /* Services */
        .services {
            padding: 60px 20px;
            text-align: center;
        }

        .services h2 {
            font-size: 35px;
            margin-bottom: 40px;
        }

        .cards {
            display: flex;
            justify-content: center;
            gap: 25px;
            flex-wrap: wrap;
        }

        .card {
            background-color: white;
            width: 280px;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 5px 15px rgba(0,0,0,0.1);
        }

        .card h3 {
            margin-bottom: 15px;
            color: #007bff;
        }

        .card p {
            line-height: 1.6;
        }

        /* Contact */
        .contact {
            background-color: #222;
            color: white;
            padding: 60px 20px;
            text-align: center;
        }

        .contact h2 {
            margin-bottom: 20px;
        }

        .contact p {
            margin-bottom: 10px;
        }

        /* Footer */
        footer {
            background-color: #111;
            color: white;
            text-align: center;
            padding: 15px;
        }

        /* Mobile */
        @media (max-width: 600px) {
            nav {
                flex-direction: column;
                gap: 15px;
            }

            nav ul {
                flex-direction: column;
                text-align: center;
                gap: 10px;
            }

            .hero h1 {
                font-size: 35px;
            }
        }
    </style>
</head>

<body>

    <!-- Navigation -->
    <nav>
        <h2>My Website</h2>

        <ul>
            <li><a href="#home">Home</a></li>
            <li><a href="#about">About</a></li>
            <li><a href="#services">Services</a></li>
            <li><a href="#contact">Contact</a></li>
        </ul>
    </nav>


    <!-- Home -->
    <section class="hero" id="home">
        <div>
            <h1>Welcome to My Website</h1>
            <p>Create something amazing with HTML and CSS.</p>

            <a href="#about" class="btn">Learn More</a>
        </div>
    </section>


    <!-- About -->
    <section class="about" id="about">
        <h2>About Us</h2>

        <p>
            Welcome to my website! This is a simple example of a modern
            website created using HTML and CSS. You can customize the
            text, colors, images, and sections to create your own website.
        </p>
    </section>


    <!-- Services -->
    <section class="services" id="services">
        <h2>Our Services</h2>

        <div class="cards">

            <div class="card">
                <h3>Web Design</h3>
                <p>
                    We create clean and modern website designs
                    that work on computers and mobile devices.
                </p>
            </div>

            <div class="card">
                <h3>Development</h3>
                <p>
                    Build fast and responsive websites using
                    HTML, CSS, JavaScript, and other technologies.
                </p>
            </div>

            <div class="card">
                <h3>Support</h3>
                <p>
                    Get help maintaining and improving your
                    website after it has been created.
                </p>
            </div>

        </div>
    </section>


    <!-- Contact -->
    <section class="contact" id="contact">
        <h2>Contact Us</h2>

        <p>Email: example@email.com</p>
        <p>Phone: +63 900 000 0000</p>
        <p>Location: Philippines</p>
    </section>


    <!-- Footer -->
    <footer>
        <p>&copy; 2026 My Website. All Rights Reserved.</p>
    </footer>

</body>
</html>
