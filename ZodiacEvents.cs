namespace ZodiacApp.Models;

public class ZodiacEvent
{
    public string Name { get; set; }
    public string Date { get; set; }
    public string Description { get; set; }
}

public class ZodiacEventStore
{
    public Dictionary<string, List<ZodiacEvent>> Events { get; } = new()
    {
        ["aquarius"] = new List<ZodiacEvent>
        {
            new ZodiacEvent { Name = "New Moon in Aquarius", Date = "January 24, 2025", Description = "The New Moon in Aquarius offers a chance for new beginnings, especially related to your individuality and social causes." },
            new ZodiacEvent { Name = "Full Moon in Aquarius", Date = "August 12, 2025", Description = "The Full Moon in Aquarius highlights personal freedom and community connections. It’s a time to celebrate progress in your social or career goals." },
            new ZodiacEvent { Name = "Saturn enters Pisces", Date = "March 7, 2025", Description = "Saturn's shift into Pisces marks a time for reevaluating spiritual beliefs and emotional boundaries." },
            new ZodiacEvent { Name = "Mercury Retrograde in Aquarius", Date = "January 1 - January 25, 2025", Description = "A period of reflection and communication issues, particularly in friendships and social circles. A time to rethink your long-term goals." }
        },

        ["pisces"] = new List<ZodiacEvent>
        {
            new ZodiacEvent { Name = "New Moon in Pisces", Date = "February 19, 2025", Description = "The New Moon in Pisces invites new spiritual insights and creative endeavors. A perfect time for artistic beginnings." },
            new ZodiacEvent { Name = "Full Moon in Pisces", Date = "September 1, 2025", Description = "The Full Moon in Pisces brings heightened intuition and emotional release. Reflect on what needs to be let go of in your personal life." },
            new ZodiacEvent { Name = "Mercury Retrograde in Pisces", Date = "March 5 - March 28, 2025", Description = "During Mercury Retrograde in Pisces, be cautious with communications, particularly around dreams and creative projects." },
            new ZodiacEvent { Name = "Neptune enters Aries", Date = "March 30, 2025", Description = "Neptune’s move into Aries will inspire innovation, idealism, and spiritual clarity, particularly for your personal growth." }
        },

        ["aries"] = new List<ZodiacEvent>
        {
            new ZodiacEvent { Name = "New Moon in Aries", Date = "April 1, 2025", Description = "The New Moon in Aries encourages fresh starts in your career and personal life. This is a bold moment for taking risks and initiating new projects." },
            new ZodiacEvent { Name = "Full Moon in Aries", Date = "October 9, 2025", Description = "The Full Moon in Aries provides clarity on your personal ambitions and the action steps needed to achieve your goals." },
            new ZodiacEvent { Name = "Mercury Retrograde in Aries", Date = "April 1 - April 24, 2025", Description = "Mercury retrograde in Aries will challenge your communication and decision-making. Take time to reassess personal projects and avoid impulsivity." },
            new ZodiacEvent { Name = "Jupiter enters Aries", Date = "May 18, 2025", Description = "Jupiter’s entry into Aries offers optimism and new opportunities, especially in career and personal growth." }
        },

        ["taurus"] = new List<ZodiacEvent>
        {
            new ZodiacEvent { Name = "Full Moon in Taurus", Date = "May 1, 2025", Description = "The Full Moon in Taurus brings clarity and culmination to financial and material goals. Focus on stability and personal values." },
            new ZodiacEvent { Name = "New Moon in Taurus", Date = "April 26, 2025", Description = "The New Moon in Taurus is a powerful time to set intentions for long-term financial stability, personal growth, and cultivating security." },
            new ZodiacEvent { Name = "Mercury Retrograde in Taurus", Date = "April 1 - April 24, 2025", Description = "Mercury Retrograde in Taurus suggests revisiting your financial plans and reassessing your values." },
            new ZodiacEvent { Name = "Saturn enters Taurus", Date = "May 21, 2025", Description = "Saturn’s shift into Taurus prompts deep, long-term changes in areas related to personal finances, relationships, and stability." }
        },

        ["gemini"] = new List<ZodiacEvent>
        {
            new ZodiacEvent { Name = "Jupiter in Gemini", Date = "January 1 - June 8, 2025", Description = "A period of expansion and growth in communication, learning, and local travel. Embrace new ideas and connect with your community." },
            new ZodiacEvent { Name = "Uranus enters Gemini", Date = "July 7 - November 7, 2025", Description = "A transformative phase bringing innovative ideas and unexpected changes. Embrace new technologies and unconventional thinking." },
            new ZodiacEvent { Name = "Full Moon in Gemini", Date = "December 4, 2025", Description = "A time to release old patterns and embrace new perspectives. Reflect on your personal growth and communication style." },
            new ZodiacEvent { Name = "Mercury Retrograde in Gemini", Date = "May 5 - May 25, 2025", Description = "A time to reflect on communication, technology, and travel. Be cautious with plans and stay organized to avoid delays." },
            new ZodiacEvent { Name = "New Moon in Gemini", Date = "June 4, 2025", Description = "A good time to set intentions around communication, education, and travel. Focus on self-expression and adapting to new experiences." },
            new ZodiacEvent { Name = "Mars enters Gemini", Date = "March 30 - May 12, 2025", Description = "A time of increased mental energy and action. Focus on pursuing new ideas, making decisions, and asserting your thoughts." }
        },

        ["cancer"] = new List<ZodiacEvent>
        {
            new ZodiacEvent { Name = "Full Moon in Cancer", Date = "January 13, 2025", Description = "A time to focus on home and emotional well-being. Reflect on your personal life and make adjustments as needed." },
            new ZodiacEvent { Name = "Mars Retrograde in Cancer", Date = "January 6 - February 23, 2025", Description = "A period to reconsider your approach to action and assertiveness. Reflect on past endeavors and plan for future initiatives." },
            new ZodiacEvent { Name = "Jupiter enters Cancer", Date = "June 9, 2025", Description = "A 12-year cycle begins, bringing opportunities for growth and expansion in personal and family matters." },
            new ZodiacEvent { Name = "Sun enters Cancer/Summer Solstice", Date = "June 20, 2025", Description = "A time to embrace home, family, and motherhood. Create unforgettable moments with loved ones and soak up the gifts of nature." },
            new ZodiacEvent { Name = "New Moon in Cancer", Date = "July 2, 2025", Description = "A great time for setting intentions regarding family, home, and emotional well-being. Focus on nurturing your personal life and creating a secure environment." },
            new ZodiacEvent { Name = "Mercury Retrograde in Cancer", Date = "June 1 - June 22, 2025", Description = "A period of revisiting emotional connections and family matters. Be mindful of communication breakdowns and misunderstandings during this phase." }
        },

        ["leo"] = new List<ZodiacEvent>
        {
            new ZodiacEvent { Name = "Mercury Retrograde in Leo", Date = "July 18 - August 11, 2025", Description = "A period to reflect on personal expression and communication. Be mindful of misunderstandings and delays." },
            new ZodiacEvent { Name = "Full Moon in Leo", Date = "February 12, 2025", Description = "A time for self-expression and creativity. Embrace your individuality and showcase your talents." },
            new ZodiacEvent { Name = "Venus Retrograde in Aries and Pisces", Date = "March 1 - April 12, 2025", Description = "A phase to reassess relationships and values. Reflect on what truly matters in your connections." },
            new ZodiacEvent { Name = "Mars Retrograde in Leo and Cancer", Date = "December 6, 2024 - February 23, 2025", Description = "A time to reconsider your approach to action and assertiveness. Reflect on past endeavors and plan for future initiatives." }
        },

        ["virgo"] = new List<ZodiacEvent>
        {
            new ZodiacEvent { Name = "Full Moon in Virgo", Date = "March 14, 2025", Description = "A total lunar eclipse that emphasizes organization, health, and personal growth. Reflect on routines and make necessary adjustments." },
            new ZodiacEvent { Name = "New Moon in Virgo", Date = "September 21, 2025", Description = "A partial solar eclipse encouraging the setting of intentions related to health, productivity, and personal development. Focus on creating new habits and routines." },
            new ZodiacEvent { Name = "Mercury Retrograde in Virgo", Date = "August 10 - September 2, 2025", Description = "Expect delays and miscommunications. Double-check all work and details, and be patient with challenges in communication and technology." },
            new ZodiacEvent { Name = "Venus enters Virgo", Date = "October 8 - November 4, 2025", Description = "A period focused on practical love, relationships, and self-care. Perfect time to evaluate relationships with a critical and efficient mindset." },
            new ZodiacEvent { Name = "Mars enters Virgo", Date = "July 28 - September 5, 2025", Description = "A time for taking action on health, work, and routine. Mars energizes Virgo’s perfectionist tendencies and encourages forward momentum in personal and professional life." }
        },

        ["libra"] = new List<ZodiacEvent>
        {
            new ZodiacEvent { Name = "New Moon in Libra", Date = "October 21, 2025", Description = "A time to set intentions for new beginnings in relationships and partnerships. Focus on balance and harmony." },
            new ZodiacEvent { Name = "Full Moon in Libra", Date = "April 14, 2025", Description = "Focus on balancing personal needs with others’ expectations. A time for reflection on your relationships." },
            new ZodiacEvent { Name = "Venus enters Libra", Date = "October 13, 2025", Description = "Venus enhances charm and social energy. It's a great time to connect with others and nurture your relationships." },
            new ZodiacEvent { Name = "Mars enters Libra", Date = "November 5 – December 19, 2025", Description = "Energy boosts for collaboration and partnerships. A good time to resolve conflicts and improve team dynamics." },
            new ZodiacEvent { Name = "Sun enters Libra", Date = "September 23, 2025", Description = "The start of Libra season, bringing attention to fairness, balance, and beauty. Focus on your relationships and social connections." }
        },



        ["scorpio"] = new List<ZodiacEvent>
        {
            new ZodiacEvent { Name = "New Moon in Scorpio", Date = "November 13, 2025", Description = "A transformative time for personal growth and emotional healing. Focus on letting go of the past and embracing new beginnings." },
            new ZodiacEvent { Name = "Full Moon in Scorpio", Date = "May 14, 2025", Description = "Clarity around deep emotions. Focus on releasing grudges and healing from past wounds." },
            new ZodiacEvent { Name = "Venus Retrograde in Scorpio", Date = "October 1 – November 6, 2025", Description = "Reflect on emotional intimacy, relationships, and financial commitments. It's a time to reevaluate your deep connections." },
            new ZodiacEvent { Name = "Mars enters Scorpio", Date = "December 20, 2025 – January 30, 2026", Description = "Increased focus and determination. A great time to tackle complex challenges and delve deep into personal transformation." },
            new ZodiacEvent { Name = "Sun enters Scorpio", Date = "October 23, 2025", Description = "The start of Scorpio season, a time for personal empowerment and embracing your true self." }
        },


        ["sagittarius"] = new List<ZodiacEvent>
        {
            new ZodiacEvent { Name = "New Moon in Sagittarius", Date = "December 7, 2025", Description = "A time to set travel or education goals. A great moment to broaden your horizons and explore new opportunities." },
            new ZodiacEvent { Name = "Full Moon in Sagittarius", Date = "June 14, 2025", Description = "Insights into beliefs and philosophies. A time to reflect on personal truths and gain clarity on your spiritual path." },
            new ZodiacEvent { Name = "Venus Retrograde in Sagittarius", Date = "July 25 - September 6, 2025", Description = "Reassess life goals and relationships. Avoid making impulsive decisions regarding love or finances." },
            new ZodiacEvent { Name = "Mars enters Sagittarius", Date = "October 5 - November 19, 2025", Description = "Increased energy for adventure and exploring new opportunities. It's an ideal time to take action on your goals." }
        },



        ["capricorn"] = new List<ZodiacEvent>
        {
            new ZodiacEvent { Name = "Mars enters Capricorn", Date = "December 15, 2025", Description = "Mars transits into Capricorn, enhancing determination and ambition. A favorable period for initiating projects and pursuing goals with discipline." },
            new ZodiacEvent { Name = "Full Moon in Capricorn", Date = "July 10, 2025", Description = "A time to reflect on professional achievements and long-term goals. Seek clarity in your ambitions." },
            new ZodiacEvent { Name = "Mercury enters Capricorn", Date = "January 8, 2025", Description = "Mercury's entry into Capricorn enhances strategic thinking and communication. Ideal for planning and decision-making." },
            new ZodiacEvent { Name = "Sun enters Capricorn", Date = "December 21, 2025", Description = "The beginning of Capricorn season, marking a time of focus on discipline, responsibility, and long-term goals." },
            new ZodiacEvent { Name = "Venus enters Capricorn", Date = "December 24, 2025", Description = "Venus transits into Capricorn, emphasizing practical expressions of love and a focus on commitment in relationships." }
        },




    };
}

