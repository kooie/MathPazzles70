namespace Q04
{
    public static class Q04Resolver
    {
        public static int Resolve(int length, int maxCutCount)
        {
            var phase = 0;
            var service = new RodCuttingService(new Rod(length));
            while (true)
            {
                if (service.Completed) return phase;
                service = service.RequestToCut(maxCutCount);
                phase = phase + 1;
            }
        }
    }
}
