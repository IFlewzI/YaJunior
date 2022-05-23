using System;

namespace Gladiatorial_Fight
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(200, 40);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            // Player stats
            int playerInput;
            string playerName;
            string playerClass = "Воин";
            float playerMaxHealth = 150;
            float playerHealth = playerMaxHealth;
            float playerArmor = 0;
            // Player attacks stats
            int playerFirstSkillMinDamage = 200;
            int playerFirstSkillMaxDamage = 300;
            float playerFirstSkillDamage;
            float playerSecondSkillArmorDebuff = 0.2f;
            float playerSecondSkillPercentArmorDebuff = playerSecondSkillArmorDebuff * 100;
            int playerThirdSkillMinDamage = 400;
            int playerThirdSkillMaxDamage = 650;
            float playerThirdSkillDamage;
            float playerFourthSkillArmorBuff = 0.9f;
            float playerFourthSkillPercentArmorBuff = playerFourthSkillArmorBuff * 100;
            bool isEnemyStunned = false;
            bool isSpecialAttackRunning = false;
            // Boss stats
            string bossName = "Ледяной великан";
            float bossMaxHealth = 1800;
            float bossHealth = bossMaxHealth;
            float bossArmor = 0;
            float bossDefaultDamage = 20;
            bool isBossFirstSpecialAttackRunning = false;
            bool isBossSecondSpecialAttackRunning = false;
            // Boss attacks stats
            int bossFirstSkillMinDamage = 20;
            int bossFirstSkillMaxDamage = 35;
            float bossFirstSkillDamage;
            int bossSecondSkillMinDamage = 35;
            int bossSecondSkillMaxDamage = 60;
            float bossSecondSkillDamage;
            int bossFirstSpecialSkillDamage = 5000;
            int bossSecondSpecialSkillDamage = 150;
            // Other 
            int roundNumber = 1;
            int currentRoundPlayerMove;
            int currentRoundBossMove;
            float damageToPlayer;
            float damageToBoss;
            bool playerDodge = false;
            bool isDataOkay = false;
            Random rand = new Random();

            // Start
            Console.Write("Спасибо, что запустили нашу преальфа-бета-альфа игру. " +
                "\nСейчас вам предстоит пройти тяжелейшую схватку, из которой выйти живым будет очень сложно. " +
                "\n\nДля начала введите имя персонажа. Пусть мир знает своего героя! ");
            playerName = Console.ReadLine();

            Console.WriteLine("Итак, {0}, я наделяю вас классом {1}, а также следующими характеристиками и умениями: ", playerName, playerClass);
            Console.WriteLine("{0}. \nЗдоровье - {1} \nУмение №1 - Глубокий порез: Проведите удар мечом и нанесите от {2} до {3} урона " +
                "по противнику.\n", playerClass, playerHealth, playerFirstSkillMinDamage, playerFirstSkillMaxDamage);
            Console.WriteLine("Умение №2 - Оглушительный крик: Ошеломите противника своим криком и понизьте его способность к блокированию атак. " +
                "После применения противник начинает получать на {0}% урона больше.\n", playerSecondSkillPercentArmorDebuff);
            Console.WriteLine("Умение №3 - Подлый трюк: Воспользуйтесь дезориентацией врага и проведите сокрушающий удар. " +
                "Для активации умения на противнике должен быть статус ошеломлённости. Умение наносит от {0} до {1} урона, " +
                "а также снимает с противника статус ошёломлённости (После нанесения урона). Также подлый трюк может помешать " +
                "врагу в подготовке некоторых заклинаний/атак.\n", playerThirdSkillMinDamage, playerThirdSkillMaxDamage);
            Console.WriteLine("Умение №4 - Ростовой щит: Примите позицию обороны и проигнорируйте {0}% урона от следующей атаки противника.\n", playerFourthSkillPercentArmorBuff);
            Console.WriteLine("\nИтак, {0}, вы готовы начать битву? \nНажмите любую кнопку чтобы продолжить...", playerName);
            Console.ReadKey();

            Console.WriteLine("\nС грохотом стена перед вами разрушается и её части падают на землю... Из образовавшегося облака пыли к вам " +
                "выходит {0}. Он замахивает руку чтобы атаковать вас, но в последний момент вы перекатываетесь " +
                "в укрытие и избегаете урона. Пришло время для битвы... ", bossName);

            // Fight
            while (playerHealth > 0 && bossHealth > 0)
            {
                damageToPlayer = 0;
                damageToBoss = 0;
                playerArmor = 0;
                if (playerHealth > 0)
                {
                    Console.WriteLine("Раунд №{0}.", roundNumber);
                    Console.WriteLine("Каков будет ваш ход, герой? Выберите умение: \n");

                    do
                    {
                        isDataOkay = false;
                        Console.WriteLine("1. Глубокий порез \n" +
                            "2. Оглушительный крик \n" +
                            "3. Подлый трюк \n" +
                            "4. Ростовой щит");
                        Console.Write("Введите номер умения: ");
                        playerInput = Convert.ToInt32(Console.ReadLine());
                        if (playerInput > 0 && playerInput < 5)
                            isDataOkay = true;
                        else
                            Console.WriteLine("Были введены неверные данные. Попробуйте использовать цифры от 1 до 4");
                    } while (isDataOkay == false);
                    currentRoundPlayerMove = playerInput;

                    switch (currentRoundPlayerMove)
                    {
                        case 1:
                            playerFirstSkillDamage = rand.Next(playerFirstSkillMinDamage, playerFirstSkillMaxDamage);
                            damageToBoss = playerFirstSkillDamage * (1 - bossArmor);
                            Console.WriteLine("\nВы проводите атаку мечом и наносите {0} урона", damageToBoss);
                            bossHealth -= damageToBoss;
                            break;
                        case 2:
                            Console.WriteLine("\nВы вскрикиваете так громко, что противник дезориентируется и становится лёгкой мишенью для вашего клинка.");
                            isEnemyStunned = true;
                            bossArmor -= playerSecondSkillArmorDebuff;
                            break;
                        case 3:
                            if (isEnemyStunned == true)
                            {
                                playerThirdSkillDamage = rand.Next(playerThirdSkillMinDamage, playerThirdSkillMaxDamage);
                                damageToBoss = playerThirdSkillDamage * (1 - bossArmor);
                                Console.WriteLine("\nВы, пользуясь уязвимостью врага, атакуете его в слабое место и наносите {0} урона.", damageToBoss);
                                bossHealth -= damageToBoss;
                                isEnemyStunned = false;
                                bossArmor += playerSecondSkillArmorDebuff;
                                if (isSpecialAttackRunning == true)
                                {
                                    Console.WriteLine("Также вы прервали противника во время подготовки заклинания, что заставит его пропустить ход.");
                                    isSpecialAttackRunning = false;
                                }
                            }
                            else
                            {
                                damageToPlayer = bossDefaultDamage * (1 - playerArmor);
                                Console.WriteLine("\nВы пытаетесь атаковать врага в слабое место, но он раскрывает ваши намерения и контратакует!" +
                                    "\nВы получили {0} урона.", damageToPlayer);
                                playerHealth -= damageToPlayer;
                            }
                            break;
                        case 4:
                            Console.WriteLine("\nВы поднимаете свой щит в ожидании атаки врага... Защита в этот ход повышена на {0}.", playerFourthSkillArmorBuff);
                            playerArmor += playerFourthSkillArmorBuff;
                            break;
                    }
                    Console.WriteLine("\nУ великана осталось {0} единиц здоровья.", bossHealth);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("К превеликому сожалению, герой не пережил эту схватку... Не хватило ему опыта и сил... \n\nПоражение(");
                    break;
                }

                if (bossHealth > 0)
                {
                    currentRoundBossMove = rand.Next(1, 5);

                    if (isBossFirstSpecialAttackRunning == false && isBossSecondSpecialAttackRunning == false)
                    {
                        switch (currentRoundBossMove)
                        {
                            case 1:
                                bossFirstSkillDamage = rand.Next(bossFirstSkillMinDamage, bossFirstSkillMaxDamage);
                                damageToPlayer = bossFirstSkillDamage * (1 - playerArmor);
                                Console.WriteLine("{0} атакует вас своей ладонью и наносит {1} единиц урона.", bossName, damageToPlayer);
                                playerHealth -= damageToPlayer;
                                break;
                            case 2:
                                playerDodge = Convert.ToBoolean(rand.Next(0, 2));
                                Console.Write("{0} Достаёт из-за пазухи ледяные копья и метает их в вас, ", bossName);
                                if (playerDodge == true)
                                {
                                    Console.WriteLine("но вы смогли увернуться!");
                                    playerDodge = false;
                                }
                                else
                                {
                                    bossSecondSkillDamage = rand.Next(bossSecondSkillMinDamage, bossSecondSkillMaxDamage);
                                    damageToPlayer = bossSecondSkillDamage * (1 - playerArmor);
                                    Console.WriteLine("после чего наносит {0} единиц урона.", damageToPlayer);
                                    playerHealth -= damageToPlayer;
                                }
                                break;
                            case 3:
                                Console.WriteLine("{0} вздымает руки к небу и в его руках появляется синий шар, излучающий неимоверное " +
                                    "количество магии... Вполне вероятно, что он готовит что-то серьёзное...", bossName);
                                isBossFirstSpecialAttackRunning = true;
                                isSpecialAttackRunning = true;
                                break;
                            case 4:
                                Console.WriteLine("{0} поднимает вокруг вас ледяную клетку, от которой исходят едва уловимые пульсации...", bossName);
                                isBossSecondSpecialAttackRunning = true;
                                break;
                        }
                    }
                    else if (isBossFirstSpecialAttackRunning == true)
                    {
                        if (isSpecialAttackRunning == true)
                        {
                            damageToPlayer = bossFirstSpecialSkillDamage * (1 - playerArmor);
                            Console.Write("Синий шар поднимается в небо... После чего с ослепляющей яркостью взрывается... " +
                                "Вам нанесено {0} единиц урона... ", damageToPlayer);
                            playerHealth -= damageToPlayer;
                            if (playerArmor >= playerFourthSkillArmorBuff) 
                            {
                                Console.WriteLine("К сожалению щит не помог..."); 
                            }
                            else
                            {
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Синий шар рассеивается и магия перестаёт витать в воздухе...");
                        }
                        isBossFirstSpecialAttackRunning = false;
                        isSpecialAttackRunning = false;
                    }
                    else if (isBossSecondSpecialAttackRunning == true)
                    {
                        damageToPlayer = bossSecondSpecialSkillDamage * (1 - playerArmor);
                        Console.WriteLine("Ледяная клетка выпускает из себя множество кольев, нанося вам {0} урона", damageToPlayer);
                        playerHealth -= damageToPlayer;
                        if (playerArmor >= playerFourthSkillArmorBuff && playerHealth > 0)
                        {
                            Console.WriteLine("Щит буквально спас вас...");
                        }
                        isBossSecondSpecialAttackRunning = false;
                    }
                    Console.WriteLine("\nУ вас осталось {0} единиц здоровья \n", playerHealth);
                    roundNumber++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Доблестный герой сразил злодея и восторжествовало спокойствие! \n\nПобеда!");
                    break;
                }
            }
        }
    }
}
