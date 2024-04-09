# Is a VS Has a

Первое правило выбора между "является" и "содержит" подразумевает, что если отношение похоже на "является", но тип наследуемого объекта **по логике работы программы может меняться**, то правильным отношением будет "содержит".

### Отношение между объектами Телевизор и Экран похоже на "является", но так как логика работы может предполагать динамическое изменение типа, то предпочтительнее выбрать отношение "содержит".

~~~C#
public class Tv
    {
        private Screen _screen { get; set; }

        public Tv (Screen screen)
        {
            this._screen = screen;
        }

        public void ReplaceScreen(Screen screen)
        {
            this._screen = screen;
        }

        public void Show() => this._screen.Show();
    }

    public class Screen
    {
        public void Show() { }
    }
~~~


### Отношение между объектами Очки и Линзы похоже на "является", но так как логика работы может предполагать динамическое изменение типа, то предпочтительнее выбрать отношение "содержит".

~~~C#
 public class Glasses
    {
        private Lenses _lenses { get; set; }

        public Glasses (Lenses lenses)
        {
            this._lenses = lenses;
        }

        public void Magnitify() => _lenses.Magnitify();
    }

    public class Lenses
    {
        public void Magnitify(){}
    }
~~~