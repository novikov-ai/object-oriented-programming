# Попытка присваивания

Добавляем в классы `General` и `Any` метод с попыткой присваивания:
~~~C#
 public static void AssignmentAttempt(ref T target, T source)
        {
            if (target.GetType() == source.GetType())
            {
                target = source;
                return;
            }

            target = new None();
        }
~~~

Если тип источника и цели совпадают, то выполняем безопасное присваивание. 

Если типы различаются, то целевому объекту присваивается тип `None`.