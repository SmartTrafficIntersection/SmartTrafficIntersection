namespace SmartTrafficIntersection
{
    public class Agent : IAgent
    {
        private readonly Policy _policy;

        public Agent(int states, int actions)
        {
            double _alpha = 0.23;
            double _gamma = 0.94;

            _policy = new QPolicy(states, actions, _alpha, _gamma);
        }
        public void Learn(int state1, int state2, int action, int reward)
        {
            _policy.Learn(state1, state2, action, reward);
        }
        public int GetBestMove(int state)
        {
            return _policy.GetBestMove(state);
        }

        public void Report()
        {
            _policy.Report();
        }
    }
}
